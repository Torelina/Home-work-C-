﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta
{
     class Pasta
    {
        
        public void Composition(string Dough)
        {

            if (Dough == "мука вода")
            {
                Console.WriteLine("Это макароны");
                
            }
            else
            {
                Console.WriteLine("Ошибка, данный продукт не относится к макаронам");
            }
        
            
        }
        
    }
}
