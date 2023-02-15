using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Common.DTOs
{
    public class ChildrenDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Tz { get; set; }

        public UserDTO Parent { get; set; }

        public int ParentId { get; set; }

    }
}
