using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BLL
{
    public class VolunteerBLL
    {
        HospitalVolunteersDBEntities3 DB = new HospitalVolunteersDBEntities3();
        VolunteerDAL volunteerDAL = new VolunteerDAL();
        AssignedRequestsBLL assignedRequestsBLL = new AssignedRequestsBLL();
        public string GetNameVolunteerById(int id)
        {
            return volunteerDAL.GetVolunteerById(id).NameVolunteer;
        }

        public Volunteer GetVolunteerById(int id)
        {
            return volunteerDAL.GetVolunteerById(id);
        }
        public List<Volunteer> GetVolunteers()
        {
            return volunteerDAL.GetVolunteers().ToList();
        }

        public List<string> GetAllVolunteerNames()
        {
            return volunteerDAL.GetVolunteers().Select(v => v.NameVolunteer).ToList();
        }
        //        צרי פונקצייה שתחזיר עבור כול כתובת את רשימת המתנדבים שהולכים
        //להתנדב בה בחודש הקרוב
        public List<VolunteerDTO> VolunteersByAddress(string address)
        {
            HashSet<int> seenVolunteerIds = new HashSet<int>(); // מונע כפילויות
            List<VolunteerDTO> volunteer = new List<VolunteerDTO>();
            // החודש הקרוב
            DateTime now = DateTime.Today;
            DateTime maxDate = now.AddMonths(1);
            var allAssigned = assignedRequestsBLL.GetAssignedRequests(); 


            foreach (var assign in allAssigned)
            {
                var req = assign.Requests;
                var helpReq = req?.HelpRequest;
                var vol = assign.Volunteer;

                if (req != null &&
                    helpReq != null &&
                    vol != null &&
                    helpReq.Address == address &&
                    req.DateRequests >= now &&
                    req.DateRequests <= maxDate &&
                    seenVolunteerIds.Add(vol.IdVolunteer)) // מחזיר true רק אם זה חדש
                {
                    volunteer.Add(Converters.VolunteerConverter.ConvertToDTO(vol));
                }
            }

            return volunteer;

        }
        public int GetRemainingMonthlyHours(int idv)
        {
            return volunteerDAL.GetRemainingMonthlyHours(idv);
        }

        public GetTopVolunteersByServiceDTO GetTopVolunteersByService(int serviceId)
        {
            return Converters.GetTopVolunteersByServiceConverter.ConvertToDTO(volunteerDAL.GetTopVolunteersByService(serviceId));
        }

        public void GetServiceStatistics(int idservice, out int volCnt, out int appRequestCnt)
        {
            volunteerDAL.GetServiceStatistics(idservice, out volCnt, out appRequestCnt);
        }
        public bool IsServiceHoursSufficient(int idservice)
        {
            return volunteerDAL.IsServiceHoursSufficient(idservice);
        }

        public List<GetVolunteerAssignmentsDetails_ResultDTO> getVolunteerAssignmentsDetails_ResultDTOs(int idVolunteer)
        {
            var result = volunteerDAL.GetVolunteerAssignmentsDetails(idVolunteer);
            return Converters.GetVolunteerAssignmentsDetails_ResultConverter.converttoDTO(result);
        }

        public void GetVolunteerMonthlyHours(int volunteerId, out int currentMonthHours, out int previousMonthHours)
        {
            volunteerDAL.GetVolunteerMonthlyHours(volunteerId, out currentMonthHours, out previousMonthHours);
        }
        public int GetExclusiveServicesCount(int volunteerId)
        {
            return volunteerDAL.GetExclusiveServicesCount(volunteerId);
        }
    }
}
