using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpKamp301_MY.EntityLayer.Concrete
{
    public class Category
    {

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

    }
}


/*
 * Field-Variable-Property
*/

/*
 int x; --> Direkt sınıfın içine tanımlandığı için Field olur.
*/

/*
public int y { get; set; } --> Bu Property dir. Sınıfın içinde tanımlanıp sonuna get ve set aldığı için.
*/

/*
 void test()
  {
   int z;  --> Metot içinde tanımlandığı için Variable olur.
  }
*/