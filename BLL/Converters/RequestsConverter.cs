using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
    public class RequestsConverter
    {
        public static RequestsDTO convertToDTO (Requests requests)
        {
            if (requests == null)
            {
                throw new ArgumentNullException(nameof(requests), "The result cannot be null.");
            }
            return new RequestsDTO()
            {
                DateRequests = requests.DateRequests,
                ContentRequests = requests.ContentRequests,
                HoursNumber = requests.HoursNumber,
                IdHelpRequest = requests.IdHelpRequest,
                IdRequests = requests.IdRequests,
                IdService = requests.IdService,
                StatusRequests = requests.StatusRequests
            };
        }
        public static List< RequestsDTO> convertToDTO(List<Requests> requests)
        {
            return requests.Select(x => convertToDTO(x)).ToList();
        }
    }
}
