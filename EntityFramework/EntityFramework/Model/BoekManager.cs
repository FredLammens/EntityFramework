using EntityFramework.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Model
{
    class BoekManager
    {
        private BoekContext ctx = new BoekContext();
        public void VoegBoekToe(Boek boek) {
            ctx.Boeken.Add(boek);
            ctx.SaveChanges();
        }
    }
}
