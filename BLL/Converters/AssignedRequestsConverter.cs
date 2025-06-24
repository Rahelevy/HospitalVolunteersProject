using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
    public class AssignedRequestsConverter
    {
        public static AssignedRequestsDTO ConvertToDto(AssignedRequests assignedRequests)
        {
            if (assignedRequests == null)
            {
                throw new ArgumentNullException(nameof(assignedRequests), "The result cannot be null.");
            }
            return new AssignedRequestsDTO()
            {
                IdAssignedRequests = assignedRequests.IdAssignedRequests,
                IdRequests = assignedRequests.IdRequests,
                IdVolunteer = assignedRequests.IdVolunteer
            };
        }
        public static List< AssignedRequestsDTO> ConvertToDto(List<AssignedRequests> assignedRequests)
        {
            return assignedRequests.Select(x=> ConvertToDto(x)).ToList();
        }

    }
}
