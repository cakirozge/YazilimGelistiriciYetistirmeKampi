using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Customer
    {
    
        public int Id { get; set; }

        private string _firstName; //firstname tutarız ve propert de get yaptığımızda bu döner. set yaptığımızda da bu firstname set ederiz. bunun nedeni bir değişiklik meydana geldiğinde onu get içine entegre etmek için.
        public string FirsName 
        {
            get
            {
                return "Mrs." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        } 
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
//public string FirsName { get; set; } --> public string FirsName arasındaki fark nedir?
//Best Practice
// public string FirsName { get; set; } --> property
//  public string FirsName --> field 
//get - set ne işe yarar? Encapsulation tekniklerinde inceleyelim!

//Encapsulation:
//get kullanırken geti açarız.
