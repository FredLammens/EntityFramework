using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Model
{
    class Uitgeverij
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string EmailContact { get; set; }

        public Uitgeverij(string naam, string adres, string emailContact)
        {
            Naam = naam;
            Adres = adres;
            EmailContact = emailContact;
        }
    }
}
