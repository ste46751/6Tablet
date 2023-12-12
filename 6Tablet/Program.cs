using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Tablet
{
    class tablet
    {
        public string _marca;

        public string _velocita;

        public string _dimensione;

        public string _durata;

        public tablet( string marca, string velocita, string dimensione, string durata)
        {
            _marca = marca;
            _velocita = velocita;
            _dimensione = dimensione;
            _durata = durata;
        }
        public tablet() { }
        public void leggiDati()
        {

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            tablet tablet =new tablet();

            tablet[] tab=new tablet[5];
            
        }
    }
    
}
