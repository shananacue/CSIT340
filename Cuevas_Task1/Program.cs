using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cuevas_Task1.OnlineShopping;

namespace Cuevas_Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Online Shopping Details\n");

            Thanks t1 = new Thanks(); // shows output of abstract class
            t1.inform();
            t1.showNote();

            //sample test
            BeautyProducts os1 = new BeautyProducts();
            os1.fullName = "Shanesha C. Cuevas";
            os1.Location = "Cebu City";
            os1.ContactNum = "09167023768";
            os1.category = "Beauty Products";
            os1.Item = "Makeup Brushes";
            os1.deliveryDate = DateTime.Now;

            showOrderInfo(os1); // gets compiled information from the child class BeautyProducts since it falls under the BP category.
            

        }
    }
}
