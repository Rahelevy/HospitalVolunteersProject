using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class RequestsBLL
    {
        RequestsDAL requestsDAL = new RequestsDAL();
        VolunteerBLL volunteerBLL = new VolunteerBLL();

        AssignedRequestsBLL assignedRequestsBLL = new AssignedRequestsBLL();

        public List<RequestsDTO> GetRequests()
        {
            return Converters.RequestsConverter.convertToDTO(requestsDAL.GetRequests());
        }

        // צרי פונקצייה שתחזיר עבור כול מבקש עזרה את רשימת הבקשות הלא 
        //  מאושרות שלו
        public List<RequestsDTO> UnapprovedRequests()
        {
            HelpRequestBLL helpRequestBLL = new HelpRequestBLL();
            List<RequestsDTO> requests = new List<RequestsDTO>();
            foreach (var item in helpRequestBLL.GetHelpRequests())
            {
                requests.AddRange(Converters.RequestsConverter.convertToDTO(requestsDAL.GetRequests().FindAll(x => x.StatusRequests.Equals("waiting") && x.IdHelpRequest == item.IdHelpRequest)));
            }
            return requests;
        }


        // 4
        //        צרי פונקצייה שתחזיר: שם מתנדב, שם מבקש עזרה, תאריך בקשה, תוכן
        //בקשה עבור כול הבקשות המאושרות-. צרי מחלקת עזר

        public List<ApprovedRequestsInfoDTO> GetApprovedRequestsInfo()
        {
            HelpRequestBLL helpRequestBLL = new HelpRequestBLL();
            List<ApprovedRequestsInfoDTO> result = new List<ApprovedRequestsInfoDTO>();

            List<Requests> approvedRequests = requestsDAL.GetRequests()
                .Where(r => r.StatusRequests == "approved")
                .ToList();

            foreach (var req in approvedRequests)
            {
                var assigned = req.AssignedRequests.FirstOrDefault();
                string volunteername = assigned != null && assigned.IdVolunteer.HasValue ? volunteerBLL.GetNameVolunteerById(assigned.IdVolunteer.Value) : null;
                string helpRequester = assigned != null && req.IdHelpRequest.HasValue ? helpRequestBLL.GetNameHelpRequesterById(req.IdHelpRequest.Value) : null;

                result.Add(new ApprovedRequestsInfoDTO
                {
                    NameVolunteer = volunteername,
                    NameHelpRequest = helpRequester,
                    DateRequests = req.DateRequests ?? DateTime.MinValue,
                    ContentRequests = req.ContentRequests
                });
            }

            return result;
        }


        //        צרי פונקצייה שתקבל קוד מתנדב ותחזיר את הבקשות שביצע למבקש
        //העזרה שנעזר בו הכי הרבה פעמים- בחלוקה על פי תאריכים.מייני לפי
        //תאריכים.
        public RequestsDTO GetRequestsDTOByIdRequest(int id)
        {
            var request = requestsDAL.GetRequestById(id);
            if (request == null)
                return null;
            return Converters.RequestsConverter.convertToDTO(request);
        }

        public List<RequestsDTO> GetRequestsMostHelped(int idVolunteer)
        {
            List<RequestsDTO> requests = new List<RequestsDTO>();
            var assignedRequests = assignedRequestsBLL.GetAssignedRequestsByIdVolunteer(idVolunteer);
            if (assignedRequests.Count == 0)
                return requests;
            foreach (var item in assignedRequests)
            {
                RequestsDTO requestsDTO = GetRequestsDTOByIdRequest(item.IdRequests.Value);
                if (requestsDTO != null && requestsDTO.StatusRequests.Equals("approved"))
                    requests.Add(requestsDTO);
            }
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (var r in requests)
            {
                if (r.IdHelpRequest.HasValue)
                {
                    int id = r.IdHelpRequest.Value;
                    if (freq.ContainsKey(id))
                        freq[id]++;
                    else
                        freq[id] = 1;
                }
            }
            int maxId = -1;
            int maxCount = 0;
            foreach (var pair in freq)
            {
                if (pair.Value > maxCount)
                {
                    maxId = pair.Key;
                    maxCount = pair.Value;
                }
            }
            return requests.Where(r => r.IdHelpRequest == maxId).OrderBy(x => x.DateRequests).ToList();
        }

        //        צרי פונקצייה שתחזיר לכול מתנדב את רשימת הבקשות הקרובות שלו.
        //מייני לפי שמות המתנדבים

        public List<RequestsDTO> ConverttoRequest(List<AssignedRequestsDTO> assignedRequests)
        {
            List<RequestsDTO> requests = new List<RequestsDTO>();
            foreach (var item in assignedRequests)
            {
                RequestsDTO requestsDTO = GetRequestsDTOByIdRequest(item.IdRequests.Value);
                if (requestsDTO != null && requestsDTO.StatusRequests.Equals("approved"))
                    requests.Add(requestsDTO);
            }
            return requests;
        }

        public List<RequestsByVolunteerDTO> GetRequestsPerVolunteer()
        {
            // כל המתנדבים
            List<Volunteer> volunteers = volunteerBLL.GetVolunteers();

            // כל הבקשות המאושרות לחודש הקרוב
            DateTime today = DateTime.Today;
            DateTime oneMonthLater = today.AddMonths(1);

            Dictionary<int, RequestsDTO> approvedRequests = GetRequests().Where(r => r.StatusRequests == "approved" &&
                    r.DateRequests >= today && r.DateRequests < oneMonthLater).ToDictionary(r => r.IdRequests);


            List<RequestsByVolunteerDTO> result = new List<RequestsByVolunteerDTO>();

            foreach (var v in volunteers)
            {
                var assignedRequests = v.AssignedRequests;

                List<RequestsDTO> filtered = new List<RequestsDTO>();

                foreach (var ar in assignedRequests)
                {
                    if (ar.IdRequests.HasValue && approvedRequests.TryGetValue(ar.IdRequests.Value, out var req))
                    {
                        filtered.Add(req);
                    }
                }

                result.Add(new RequestsByVolunteerDTO
                {
                    NameVolunteer = v.NameVolunteer,
                    Requests = filtered
                });
            }

            // מיון לפי שם המתנדב 
            return result.OrderBy(r => r.NameVolunteer).ToList();
        }

    }

}



