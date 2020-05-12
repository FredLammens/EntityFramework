using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data
{
    class Uitgeverij
    {
        public string Naam { get; set; }
        public int UitgeverijID { get; set; }

        public Uitgeverij(string naam)
        {
            Naam = naam;
        }
    }
}
