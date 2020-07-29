using Catel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronTaxi.Models
{
    public class User : ModelBase
    {
        public User()
        {
            Roles = new List<Role>();
        }

        public int Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string LastName { get; set; }

        public string Phohe { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }



        public DateTime? BirthDate { get; set; }

        public string Gender { get; set; }

        public byte[] Image { get; set; }

        public List<Role> Roles { get;set; }
    }
}
