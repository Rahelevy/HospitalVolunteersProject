using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GetVolunteerAssignmentsDetails_ResultDTO
    {
        public string VolunteerName { get; set; }
        public string VolunteerPhone { get; set; }
        public string ServiceName { get; set; }
        public string RequestContent { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }

    }
}
