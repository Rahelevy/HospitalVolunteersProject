using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RequestsByVolunteerDTO
    {
        public string NameVolunteer { get; set; }
        public List<RequestsDTO> Requests { get; set; }
    }
}
