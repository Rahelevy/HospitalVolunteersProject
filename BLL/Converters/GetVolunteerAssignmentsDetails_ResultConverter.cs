using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.Converters
{
    public class GetVolunteerAssignmentsDetails_ResultConverter
    {
        public static GetVolunteerAssignmentsDetails_ResultDTO converttoDTO(GetVolunteerAssignmentsDetails_Result gv)
        {
            if (gv == null)
            {
                throw new ArgumentNullException(nameof(gv), "The result cannot be null.");
            }
            return new GetVolunteerAssignmentsDetails_ResultDTO
            {
                VolunteerName = gv.VolunteerName,
                VolunteerPhone = gv.VolunteerPhone,
                ServiceName = gv.ServiceName,
                RequestContent = gv.RequestContent,
                RequestDate = gv.RequestDate
            };
           
        }
        public static List<GetVolunteerAssignmentsDetails_ResultDTO> converttoDTO(List<GetVolunteerAssignmentsDetails_Result> gvList)
        {
            return gvList.Select(gv => converttoDTO(gv)).ToList();
        }
    }
}
