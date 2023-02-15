using Milgot.Common.DTOs;

namespace Milgot.API.Models
{

    public class UserModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public EHMO HMO { get; set; }

        //public int Children { get; set; }
    }
}
