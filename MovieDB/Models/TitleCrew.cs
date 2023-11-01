using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_Database.Models
{
    public class TitleCrew
    {
        [Key]
        public string TConst { get; set; }

        public string Directors { get; set; }

        public string Writers { get; set; } 

    }
}
