using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class RequestsDAL
    {
        HospitalVolunteersDBEntities3 DB = new HospitalVolunteersDBEntities3();
       

        public Requests GetRequestById(int id)
        {
            return DB.Requests.FirstOrDefault(x => x.IdRequests == id);
        }
        public List<Requests> GetRequests()
        {
            return DB.Requests.ToList();
        }

    }
}
