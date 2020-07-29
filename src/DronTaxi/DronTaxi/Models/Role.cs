using Catel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronTaxi.Models
{
    public class Role : ModelBase
    {
        public Role()
        {
            Rights = new List<Right>();
        }

        public int Id { get; set; }

        public string RoleBase { get; set; }

        public string RoleName { get; set; }

        public DateTime? AssignDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public List<Right> Rights { get; set; }
    }
}
