using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseSystem_Project.Models;

namespace Project_EnterpriseSystem.Models
{
    public class Song
    {
        public Guid Id {get; set; }

        public required string Name {get; set; }

        public required Artist Artist {get; set; }
        public Genre Genre { get; set; }
    }
}