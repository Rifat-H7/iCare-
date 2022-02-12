using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
    public class Edoctor
    {
        public string Name { set; get; }

        public string Email { set; get; }

        public int Age { set; get; }
        public string License_Number { set; get; }
        public string Gender { set; get; }
        public string Phone_Number { set; get; }
        public string Blood_Group { set; get; }

        public string Password { set; get; }


    }
}