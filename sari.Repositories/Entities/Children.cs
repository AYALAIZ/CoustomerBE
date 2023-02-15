using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories.Entities

{

    public class Children
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Tz { get; set; }

        public User Parent { get; set; }

        public int ParentId { get; set; }
    }
}
