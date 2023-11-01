using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_Database.Models
{
    public class NameBasics
    {
        [Key]
        public string NConst { get; set; }

        public string PrimaryName { get; set; }

        public int BirthYear { get; set; }

        public int DeathYear { get; set; }

        public string PrimaryProfession { get; set; } 

         public string KnownForTitles { get; set; }
        
    }

}
