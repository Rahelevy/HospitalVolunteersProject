using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Converters
{
    public class VolunteerConverter
    {
        
        public static VolunteerDTO  ConvertToDTO(Volunteer volunteer)
        {
            if (volunteer == null)
            {
                throw new ArgumentNullException(nameof(volunteer), "The result cannot be null.");
            }
            return new VolunteerDTO()
            {
                IdVolunteer = volunteer.IdVolunteer,
                NameVolunteer = volunteer.NameVolunteer,
                Phone = volunteer.Phone
            };
        }
        public static List<VolunteerDTO> ConvertToDTO(List<Volunteer> volunteers) 
        {
            return volunteers.Select(x=> ConvertToDTO(x)).ToList();
        }
    }
}
