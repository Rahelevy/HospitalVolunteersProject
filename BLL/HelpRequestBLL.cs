using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HelpRequestBLL
    {
        RequestsBLL requestsBLL = new RequestsBLL();
        HelpRequestDAL HelpRequestDAL = new HelpRequestDAL();

        public List<HelpRequestDTO> GetHelpRequests()
        {
            return Converters.HelpRequestConverter.ConverttoDTO(HelpRequestDAL.GetHelpRequest());
        }
        public HelpRequestDTO MostUnapprovedRequests()
        {
            HelpRequestDTO helprequestDTO = new HelpRequestDTO();
            int maxCount = 0;

            foreach (var helpRequester in HelpRequestDAL.GetHelpRequest())
            {
                int count = requestsBLL.GetRequests()
                    .Count(r => r.StatusRequests == "waiting" && r.IdHelpRequest == helpRequester.IdHelpRequest);

                if (count > maxCount)
                {
                    maxCount = count;
                    helprequestDTO = Converters.HelpRequestConverter.ConverttoDTO( helpRequester);
                }
            }

            return helprequestDTO;
        }
        public string GetNameHelpRequesterById(int id)
        {
            return HelpRequestDAL.GetHelpRequestById(id).NameHelpRequest;
        }
    }
}
