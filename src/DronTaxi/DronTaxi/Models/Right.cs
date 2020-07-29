using Catel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronTaxi.Models
{
    public class Right : ModelBase
    {
        public int Id { get; set; }

        public string RightBase { get; set; }

        public string RightName { get; set; }
    }
}
