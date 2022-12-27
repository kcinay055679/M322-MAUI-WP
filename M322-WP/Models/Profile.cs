using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M322_WP.Models
{
    public class Profile
    {
        public string name { get; set; }
        public string lockScreenPath { get; set; }
        public string homeScreenPath { get; set; }

        public Profile(string name, string lockScreenPath, string homeScreenPath)
        {
            this.name = name;
            this.lockScreenPath = lockScreenPath;
            this.homeScreenPath = homeScreenPath;
        }
    }
}
