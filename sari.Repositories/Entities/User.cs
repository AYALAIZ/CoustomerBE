using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories.Entities
{
    public enum EHMO
    {
        macabi = 1, leumit = 2, clalit = 3, meuchedet = 4
    }
    public class User
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public EHMO HMO { get; set; }

        //public int Children { get; set; }


    }
}
