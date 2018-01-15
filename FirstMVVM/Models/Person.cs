using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.Models
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {

            }
        }
    }
}
