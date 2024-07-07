using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EG23
{
    public class Joueur
    {
        public string pseudo {  get; set; }
        public string programme { get; set; }
        public List<soldat> soldats { get; set; }

        public int score { get; set; }

        public int tour { get; set; }

        public Joueur(string pseudo, string programme) {
            this.pseudo = pseudo;
            this.programme = programme;
            this.score = 0;
            this.tour = 0;
            this.soldats = new List<soldat>();
            soldat s1 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s2 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s3 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s4 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s5 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s6 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s7 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s8 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s9 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s10 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s11 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s12 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s13 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s14 = new soldat(0, 0, 0, 0, 0, "defensive");
            soldat s15 = new soldat(0, 0, 0, 0, 0, "defensive");

         this.soldats.Add(s1); this.soldats.Add(s2); this.soldats.Add(s3);
         this.soldats.Add(s4); this.soldats.Add(s5); this.soldats.Add(s6);
         this.soldats.Add(s7); this.soldats.Add(s9); this.soldats.Add(s1);
         this.soldats.Add(s10); this.soldats.Add(s11); this.soldats.Add(s12);
         this.soldats.Add(s13); this.soldats.Add(s14); this.soldats.Add(s15);

        }
        
    }
}
