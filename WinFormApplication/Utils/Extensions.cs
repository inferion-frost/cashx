using Infrastructure.Facades;
using Infrastructure.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormApplication.Utils
{
    internal static class Extensions
    {
        public static bool HasPeopleInDatabase(this IPersonServiceFacade facade)
        {
            return facade.GetPeople().Count > 0;
        }

        public static GetPersonDTO GetFirstPerson(this IPersonServiceFacade facade)
        {
            return facade.GetPeople().First();
        }

        public static bool IsEmail(this string str)
        {
            try
            {
                return new MailAddress(str).Address == str;
            }
            catch
            {
                return false;
            }
        }

    }
}
