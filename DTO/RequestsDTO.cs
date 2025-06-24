using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RequestsDTO
    {
        public int IdRequests { get; set; }
        public Nullable<int> IdHelpRequest { get; set; }
        public string ContentRequests { get; set; }
        public string StatusRequests { get; set; }
        public Nullable<System.DateTime> DateRequests { get; set; }
        public Nullable<int> IdService { get; set; }
        public Nullable<int> HoursNumber { get; set; }
    }
}
