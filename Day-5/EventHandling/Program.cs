
using System;
using EventHandling;

namespace EventHandling
{
    //step 1: create the delegate class having the same signature as the event
    //step 2 : declare the event of the delegate type
    internal class Program
    {
    //Q --> When p1 is set to a value > 100, the setter fires the InvalidP1 event,
    //which calls all subscribed handlers (in your case, printing "Invalid value! P1 exceeds 100.").
        public static void Main1(string[] args) 
        {
            // using  delegate event handled
            class1 obj = new class1();
            obj.InvalidP1 += EventHandlerFunction;
            obj.p1 = 10;
            Console.WriteLine(" value-> "+obj.p1);

            static void EventHandlerFunction()
            {
                Console.WriteLine("Invalid value");
            }


        }
        
    }
    public class class1
    {
        public event InvalidEventHandler InvalidP1;
        //Invalid_P1 is a field type of delegate
        //Event — InvalidP1 is a field of that delegate type,
        ///accessible only via += / -= from outside.
        
        
        private int P1;
        public int p1
        {
            get { return P1; }
            set
            {
                if (value <= 100)
                {
                    P1 = value;
                }
                else
                {
                    if (InvalidP1 != null)
                    {
                        InvalidP1(); //call if Invalid_val is not null
                    }
                }
            }
        }

    }
   
    public delegate void InvalidEventHandler();

}
public  delegate void InvalidEventHandler(int invalidValue);
public class class2
{
    public event InvalidEventHandler InvalidP2; //InvalidP2 is  the name of event
    private int P2;
    public int p2
    {
        get { return P2; }
        set
        {
            if (value <= 100)
            {
                P2= value;
            }
            else
            {
                if(InvalidP2 != null)
                {
                    InvalidP2?.Invoke(value);
                }
            }
        }
    }

    public static void Main()
    {
        class2 cls2 = new class2();
        cls2.InvalidP2 += FunctionInvalidEventHandler;
        cls2.InvalidP2 += FunctionInvalidEventHandler;
        cls2.p2 = 133;
    }

        public static void FunctionInvalidEventHandler( int invalidValue)
    {
        Console.WriteLine("invalid"+ invalidValue);
    } 
}

