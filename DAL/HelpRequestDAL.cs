using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HelpRequestDAL
    {
        HospitalVolunteersDBEntities3 DB= new HospitalVolunteersDBEntities3();
        public List< HelpRequest> GetHelpRequest() 
        {
            return DB.HelpRequest.ToList();
        }

        public HelpRequest GetHelpRequestById(int id)
        {
            return GetHelpRequest().Find(x=> x.IdHelpRequest==id);
        }
    

      
    }
}
