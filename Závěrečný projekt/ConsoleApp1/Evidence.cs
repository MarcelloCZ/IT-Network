using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Evidence
    {

        public List<Pojistenec> Pojistenci = new List<Pojistenec>();

        
        public void PridejPojistence(Pojistenec pojistenec)
        {
            Pojistenci.Add(pojistenec); 
        }

        
        public void Vyhledat(string jmeno, string prijmeni)
        {
            foreach (var item in Pojistenci)
            {
                if(item.Jmeno == jmeno && item.Prijmeni == prijmeni)
                {
                    Console.WriteLine(item);
                }
                
            }
        }

       
        public void Vypis()
        {
            foreach (var item in Pojistenci)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
