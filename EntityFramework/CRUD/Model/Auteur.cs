using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data
{
    class Auteur
    {
        public int AuteurID { get; set; }
        public string Naam { get; set; }
        public ICollection<AuteurStrip> StripsLink { get; set; } = new List<AuteurStrip>();

        public Auteur(string naam)
        {
            Naam = naam;
        }
    }
}
