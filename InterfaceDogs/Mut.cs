using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDogs
    {
    internal class Mut : Idog
        {

        public string Name { get; set; } = "Dart";
        public string Color { get; set; } = "Brown";
        public bool IsLarge { get; set; } = true;

        public string Bark()
            {
            return ($"A Mut goes Urf!");
            }

        }

    }
