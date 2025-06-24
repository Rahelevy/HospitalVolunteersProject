using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Converters
{
    public class GetTopVolunteersByServiceConverter
    {
        public static GetTopVolunteersByServiceDTO ConvertToDTO(GetTopVolunteersByService_Result v)
        {
            if (v == null)
            {
                throw new ArgumentNullException(nameof(v), "The result cannot be null.");
            }
            return new GetTopVolunteersByServiceDTO()
            {
                IdVolunteer = v.IdVolunteer,
                NameVolunteer = v.NameVolunteer,
                Phone = v.Phone,
            };
        }
        public static List<GetTopVolunteersByServiceDTO> ConvertToDTO(List<GetTopVolunteersByService_Result> v)
        {
            return v.Select(x => ConvertToDTO(x)).ToList();
        }

    }
}
