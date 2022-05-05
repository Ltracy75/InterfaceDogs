using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDogs
    {
    internal class Boxer :Idog
        {
        public string Name { get; set; } = "Toxi";
        public string Color { get; set; } = "Blue";
        public bool IsLarge { get; set; } = true;

        public string  Bark() 
            {
            return ($"A Boxer goes Boof");
            }

        }
    }
        
   