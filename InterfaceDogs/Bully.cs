using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDogs
    {
    internal class Bully : Idog
        {
        public string Name { get; set; } = "Levi";
        public string Color { get; set; } = "Grey";
        public bool IsLarge { get; set; } = true;

        public string Bark()
            {
            return ($"A Boxer goes Snarf!");
            }

        }

    }
