using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Model
{
    class Auteur
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string EmailContact { get; set; }

        public Auteur(string naam, string emailContact)
        {
            Naam = naam;
            EmailContact = emailContact;
        }
    }
}
