using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Data
{
    class Reeks
    {
        public int ReeksID { get; set; }
        public string Naam { get; set; }
        public ICollection<Strip> Strips { get; set; } = new List<Strip>();

    }
}
