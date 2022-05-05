using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDogs
    {
    internal interface Idog
        {
        public string Name { get; set; }
        public bool IsLarge { get; set; }
        public string Color { get; set; }

        public string Bark();
        }
    }
