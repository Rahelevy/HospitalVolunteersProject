using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class AssignedRequestsBLL
    {
        HospitalVolunteersDBEntities3 DB = new HospitalVolunteersDBEntities3();
        AssignedRequestsDAL assignedRequestsDAL = new AssignedRequestsDAL();
        // 1
        // צרי פונקצייה שתקבל קוד מתנדב ותחזיר את רשימת הבקשות המשובצות 
        // לו.
        public List<AssignedRequestsDTO> GetAssignedRequestsByIdVolunteer(int idV)
        {
            return Converters.AssignedRequestsConverter.ConvertToDto( assignedRequestsDAL.GetAssignedRequestsByIdVolunteer(idV));
        }

        public List<AssignedRequests> GetAssignedRequests()
        {
            return assignedRequestsDAL.GetAssignedRequests();
        }
    }
}
