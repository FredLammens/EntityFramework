using EntityFramework.Model;
using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Uitgeverij u1 = new Uitgeverij("Jane Do", "Kerkstraat 97,1000 Hemel", "Jane@Dood.be");
            Auteur a1 = new Auteur("Michael Jackson", "michael.Jackson@Heaven");
            Boek b1 = new Boek("Hoe wordt je pedofiel", "Pedofiele is niet OK");
            b1.Uitgeverij = u1;
            b1.Auteurs.Add(a1);
            BoekManager BM = new BoekManager();
            BM.VoegBoekToe(b1);
        }
    }
}
