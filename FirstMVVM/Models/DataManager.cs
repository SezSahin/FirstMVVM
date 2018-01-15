using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstMVVM.ViewModels;

namespace FirstMVVM.Models
{
    public sealed class DataManager
    {
        static readonly DataManager _instance = new DataManager();
        public static DataManager Instance
        {
            get
            {
                return _instance;
            }
        }
        public Person ImportantPerson { get; set; }

        private DataManager()
        {
            ImportantPerson = new Person { FirstName = "Anders", LastName = "And" };
        }
    }
}
