using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
   public class Ehospital
    {
        public string VName{ set; get; }
        public string HName { set; get; }

        public string Location { set; get; }
        public int Bed { set; get; }
        public int Ambulance { set; get; }
        public int Apos { set; get; }
        public int Aneg { set; get; }
        public int ABpos { set; get; }
        public int ABneg { set; get; }
        public int Bpos { set; get; }
        public int Bneg { set; get; }
        public int Opos { set; get; }
        public int Oneg { set; get; }
       

    }
}
