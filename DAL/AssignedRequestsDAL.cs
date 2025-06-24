using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssignedRequestsDAL
    {
        HospitalVolunteersDBEntities3 DB = new HospitalVolunteersDBEntities3();
        // צרי פונקצייה שתקבל קוד מתנדב ותחזיר את רשימת הבקשות המשובצות 
        // לו.
        public List<AssignedRequests> GetAssignedRequestsByIdVolunteer(int idV)
        {
            return DB.AssignedRequests.Where(x => x.IdVolunteer == idV).ToList();
        }

        public List<AssignedRequests> GetAssignedRequests()
        {
            return DB.AssignedRequests.ToList();
        }
    }
}
