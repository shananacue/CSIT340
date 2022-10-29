using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuevas_Task1
{   /*  
        [ABSTRACTION]
        This block of code shows abstraction in the sense that it hides the details of the implementation.
        In this application, it is unecessary to see the behind-the-scenes of the messages, so I put them in
        and abstract class. 
    */
    public abstract class Inform
    {
        public abstract void inform();

        public void showNote()
        {
            Console.WriteLine("We'll see you soon!\n");
        }
    }
    
    class Thanks : Inform
    {
        public override void inform() // overrides the abstract inform in abstract class Inform
        {
            Console.WriteLine("Thank you for Shopping!");
        }

    }
         
    

    internal class OnlineShopping
    {
    /*  
        [ENCAPSULATION]
        As seen in the code below, the variables are labelled as either public or private. 
        This is so that it regulates the access of the certain variables. 
        Variables like location and Contact Number should not be so easily shared which is
        why they are labelled as private while everything else is public.  
    */
    public string fullName { get; set; }
    public string category { get; set; }// Beauty, Electronics, Household Items
    public DateTime deliveryDate { get; set; }
   
    private string location { get; set; } 
    private string conNum { get; set; }

    public string Location
        {
            get { return location; }
            set { location = value; }
        }
    public string ContactNum
        {
            get { return conNum; }
            set { conNum = value; }
        }
        public virtual string GetOrderInfo()
        {
            return "Full Name:" + fullName + "\nLocation:" + location + "(" + conNum + ") \nCategory:" + category + "\nDelivery date:" + deliveryDate.ToString("dd-MMM-yyyy") + " ";
        }

    /*
        [POLYMORPHISM THROUGH INHERITANCE]
        The following section is the main part that shows the concept of polymorphism and inheritance.
        It shows polymorphism in that it shows different types of one thing: Beauty Products, Electronics and Household
        Appliances as a type of online shopping category and it shows its different forms in the output. Inheritance is
        also present since all the classes have common properties with just a few added per class.
    */
    public class BeautyProducts : OnlineShopping
        {
           public string Item { get; set; }
           public override string GetOrderInfo()
           {
                return "Full Name:" + fullName + "\nLocation:" + location + "(" + conNum + ") \nCategory:" + category + "Item:" + Item + "\nDelivery date:" + deliveryDate.ToString("dd-MMM-yyyy") + " ";
           }
        }
    public class Electronics : OnlineShopping
        {
            public string Brand { get; set; }
            public string ModelNumber { get; set; }

            public override string GetOrderInfo()
            {
                return "Full Name:" + fullName + "\nLocation:" + location + "(" + conNum + ") \nCategory:" + category + "Brand:" + Brand + "Model Number:" + ModelNumber + "\nDelivery date:" + deliveryDate.ToString("dd-MMM-yyyy") + " ";
            }
        }

    public class HouseholdAppliances: OnlineShopping
        {
            public string warranty { get; set; }
            public string wattage { get; set; }

            public override string GetOrderInfo()
            {
                return "Full Name:" + fullName + "\nLocation:" + location + "(" + conNum + ") \nCategory:" + category + "Warranty:" + warranty + "Wattage:" + wattage + "\nDelivery date:" + deliveryDate.ToString("dd-MMM-yyyy") + " ";
            }
        }

    public static void showOrderInfo(OnlineShopping o) //shows the polymorphism through inheritance in terms of output
        {
            string info = o.GetOrderInfo();
            Console.WriteLine(info);
            Console.ReadLine();
        }

        
       
    }
 }


