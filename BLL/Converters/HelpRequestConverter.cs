using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Converters
{
    public class HelpRequestConverter
    {
        public static HelpRequestDTO ConverttoDTO(HelpRequest hr)
        {
            if (hr == null)
            {
                throw new ArgumentNullException(nameof(hr), "The result cannot be null.");
            }
            return new HelpRequestDTO()
            {
                IdHelpRequest = hr.IdHelpRequest,
                NameHelpRequest = hr.NameHelpRequest,
                PhoneHelpRequest = hr.PhoneHelpRequest,
                Address = hr.Address,
            };
        }
        public static List<HelpRequestDTO> ConverttoDTO(List<HelpRequest> hr)
        {
            return hr.Select(x => ConverttoDTO(x)).ToList();
        }

    }
}
