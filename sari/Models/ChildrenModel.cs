using Milgot.Repositories.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Milgot.API.Models
{
    public class ChildrenModel
    {
        public string Name { get; set; }

        public string Tz { get; set; }
        public DateTime BirthDate { get; set; }

        [ForeignKey("Parent")]
        public int ParentId { get; set; }

        //public UserModel Parent { get; set; }


    }
}
