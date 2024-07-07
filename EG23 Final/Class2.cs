using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EG23
{
    public class soldat
    {
        public int force { get; set; }
        public int dexterite { get; set; }
        public int resistance { get; set; }
        public int constitution { get; set; }
        public int intiativite { get; set; }
        public string strategie { get; set; }
        public soldat(int force, int dexterite, int resistance, int constitution,int initiativite, string strategie) {

            this.force = force;
            this.dexterite= dexterite;
            this.resistance = resistance;
            this.constitution= constitution;
            this.intiativite = intiativite;
            this.strategie= strategie;

        }
       
    }
}
