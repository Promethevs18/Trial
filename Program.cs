using System.Net.Sockets;

namespace Final_Day
{
    internal class Program
    {

        //it is a common practice to name your interface beginning with an I
        /* interface IAnimal // blueprint in which your child class will follow
         {

             void animalSound();
             void run();

         }*/


        /*Interface - a contract/blueprint that defines a set of methods that a class MUST
                      implement without providing any implementation details
                    - Cannot contain any implementation code
                    - A class can implement multiple interfaces
                    - It is used to specify what a class must do, but not how it does it

         Abstract - it can have both abstract methodss (walang implementation) or concrete methods (yung may implementation)
                    - can contain fields and methods with implementation
                    - a class can only extend one abstract class
                    - used to share code among related classes

         */
        /* abstract class Animal
         {
             public abstract void makeSound();

             void sleep()
             {
                 Console.WriteLine("Animal is sleeping");
             }
         }

         class Dog : Animal
         {
             public override void makeSound()
             {
                 Console.WriteLine("woof woof");
             }
            void sleep()
             {
                 Console.WriteLine("Sleeping");
             }
         }*/

        /* interface IFunctions
         {
             void CheckBalance();
             void Withdraw();
             void Deposit();
         }

         //atm, online banking (web), online banking (mobile)

         class ATM : IFunctions
         {
             public void CheckBalance()
             {
                 Console.WriteLine("Eto balance mo. Total");
             }

             public void Deposit()
             {
                 throw new NotImplementedException();
             }

             public void Withdraw()
             {
                 throw new NotImplementedException();
             }
         }
         class Mobile : IFunctions
         {
             public void CheckBalance()
             {
                 Console.WriteLine("Makikita mo ang balance mo, plus yung breakdown ng gastos at pasok");
             }

             public void Deposit()
             {
                 throw new NotImplementedException();
             }

             public void Withdraw()
             {
                 throw new NotImplementedException();
             }
         }


         *//* Attributes - are a way to add metadata to your code. They provide add information about the behavior of the elements na ginagamitan neto
          *              System.Attributes
          *            - Obsolete - marks the program as obsolete
          *            - Serializable - can be serialized
          *            - DLLImport - import a moethd from an unmanaged DLL
          *            
          *            It allows you to add declarative info to your code
          *            configuration, validation, informing the compiler about something.
          */
        /*[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
        public class Information : Attribute
        {
            public string Author { get; }
            public string Version { get; }

            public Information(string author, string version)
            {
                    Author = author;
                Version = version;
            }
        }

        [Information("Jack Ryan", "1.0")]
        public class Mayaman
        {
            public void SampleMethod()
            {
                Console.WriteLine("Hellow");
            }
        }*/


        /* enums - a special class the represents a group of constants
         *       - short for enumerations which means specifically listed
         */
        /*enum Level
        {
            Low, Medium, High
        }*//*

        public enum Size
        {
            Tall, Venti, Grade
        }
        public enum Type
        {
            Espresso, Latte, Capuccino, Americano
        }
        public enum OrderStatus
        {
            Pinipitas, Processing, Completed, Cancelled
        }

        public class CoffeeOrder
        {
            public int OrderId { get; set; }
            public Type type { get; set; }
            public Size size { get; set; }
            public OrderStatus stat { get; set; }

            public CoffeeOrder(int id, Type type, Size size)
            {
                OrderId = id;
                this.type = type;
                this.size = size;

            }

            public void ProcessOrder()
            {
                stat = OrderStatus.Processing;
                Console.WriteLine($"Order {OrderId} is processed");
            }
            public void CompleteOrder()
            {
                stat = OrderStatus.Completed;
                Console.WriteLine($"Order {OrderId} is completed");
            }
            public void CancelOrder()
            {
                stat = OrderStatus.Cancelled;
                Console.WriteLine($"Order {OrderId} is Cancelled");
            }
        }*/

        //File class is a class from the System.IO namespace

        //AppendText, copy, create, delete, etc


        //Delegates and events are key features in C# that enable flexible and powerful programming, lalo na kapag handling events at callbacks

        //Example Alarm Clock

       // public delegate void AlarmEventHandler(object sender, EventArgs e);

     /*   public class Alarmclock
        {
            public event AlarmEventHandler Alarm;

            public void SetAlarm(TimeSpan alarmTime)
            {
                Console.WriteLine($"Alarm set for {alarmTime}");
                System.Threading.Thread.Sleep(alarmTime);
                OnAlarmEvent();
            }

            protected virtual void OnAlarmEvent()
            {
               if(Alarm != null)
                {
                    Alarm(this, EventArgs.Empty);
                }
            }
        }
        public class AlarmListener
        {
            public void OnAlarm(object sender, EventArgs e)
            {
                Console.WriteLine("Gising, loko!");
            }
        }*/

  /*  public delegate void BookEventHandler(object sender, EventArgs e);
    
    public class Book 
    {
        public event BookEventHandler BookHandler;
        
        public void BorrowBook(String bookTitle)
        {
            Console.WriteLine($"The book, \"{bookTitle}\" has been borrowed.");
        }
        
        public void ReturnBook(String bookTitle)
        {
            Console.WriteLine($"The book, \"{bookTitle}\" has been returned.");
        }
        
        protected virtual void OnBookEvent()
        {
            if(BookHandler != null)
            {
                BookHandler(this, EventArgs.Empty);
            }
        }
    }
    public class BookEventListener
    {
        public void OnReturnBook(object sender, EventArgs e)
        {
            Console.WriteLine("The book has been returned");
        }
        public void OnBorrowBook(object sender, EventArgs e)
        {
            Console.WriteLine("The book has been borrowed");
        }
    }*/

        static void Main(string[] args)
        {
            /* Book book = new Book();
             BookEventListener bookEventListener = new BookEventListener();

             book.BookHandler += bookEventListener.OnBorrowBook;
             book.BookHandler += bookEventListener.OnReturnBook;

             book.BorrowBook("Sofia the First by ExBatallion");
             book.ReturnBook("Jhonna the Second by Lil Wayne");

             Console.WriteLine("Press any key to finish");
             Console.ReadKey();*/
            /* Alarmclock alarmclock = new Alarmclock();

             AlarmListener alarmListener  = new AlarmListener();


             //Subscribe to the event
             alarmclock.Alarm += alarmListener.OnAlarm;

             //Set the alarm
             alarmclock.SetAlarm(TimeSpan.FromSeconds(3));

             Console.WriteLine("Press any key to finish");
             Console.ReadKey();
 */


            /*Collections and generics are esential concepts when managing data ro objects
              Collections - data strutures that store multipel items

                          - ArrayList - a dynamic array that can grow and shrink
                          - HashTable
                          - Queue (FIFO)
                          - Stack (LIFO)
            */

            /*List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(2);
            numbers.Remove(10);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }*/

            //Dictionary - collection of key-value pairs - keys are unique and you can look up values by their keys
            /*Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Lucas", 32);
            ages.Add("Sofia", 33);
            ages.Add("Jhona", 34);

            foreach(var age in ages.Values)
            {
                Console.WriteLine(age);
            }*/

            //Queue - another collection that uses the FIFO structure
            /*Queue<string> queue = new Queue<string>();
            queue.Enqueue("Sofia");
            queue.Enqueue("Lucas");
            queue.Dequeue();

            foreach(var queues in queue)
            {
                Console.WriteLine(queues);
            }*/

            //Stack - collection that uses LIFO
           /* Stack<string> stacks = new Stack<string>();

            stacks.Push("Edward");
            stacks.Push("Jhona");

            stacks.Pop();
            foreach(var pop in stacks)
            {
                Console.WriteLine(pop);
            }*/

            //Hashset - collection that stores no duplicate elements
            HashSet<double> d = new HashSet<double>();
            d.Add(1);
            d.Add(2);
            d.Add(1);

            foreach(var item in d)
            {
                Console.WriteLine(item);
            }
            //interfaces
            //attributes
            //enums
            //files
            //delegates and events
            //collections and generics
            //List and dictionaries

            //BONUS - i will demo kung paano gumawa ng simpleng c# na wpf application na nakaconnect sa database


            //INTERFACES - IS ANOTHER  WAY OF ACHIEVING ABSTRACTION


            /*     Mobile mobile = new Mobile();
                 mobile.CheckBalance();

                 ATM atm = new ATM();
                 atm.CheckBalance();*/

            /* Type type = typeof(Mayaman);

             Information classInfo = (Information)Attribute.GetCustomAttribute(type, typeof(Information));
             if(classInfo != null)
             {
                 Console.WriteLine($"{ classInfo.Author} + { classInfo.Version}");
             }*/

            /* Level value = Level.Medium;
             Console.WriteLine(value);*/

            /*  CoffeeOrder order1 = new CoffeeOrder(1, Type.Espresso, Size.Venti);
              CoffeeOrder order2 = new CoffeeOrder(1, Type.Americano, Size.Grade);

              Console.WriteLine($"Order {order1.OrderId}:  {order1.type}, {order1.size}, Status: {order1.stat}");
              order1.ProcessOrder();
              Console.WriteLine($"Order {order1.OrderId}:  {order1.type}, {order1.size}, Status: {order1.stat}");

              Console.WriteLine($"Order {order2.OrderId}:  {order2.type}, {order2.size}, Status: {order2.stat}");
              order2.ProcessOrder();
              Console.WriteLine($"Order {order2.OrderId}:  {order2.type}, {order2.size}, Status: {order2.stat}");*/


            /*  string text = "This is our text from Final Day";
              File.WriteAllText("A:\\Documents\\filename.von", text, System.Text.Encoding.UTF7);

              string readFile = File.ReadAllText("A:\\Documents\\filename.von");
              Console.WriteLine(readFile);*/

            /*
                Simple Library Management System
                        Overview
                        The system will:

                        Add a single book to the library.
                        Add a single user.
                        Borrow and return the book.

                        Classes
                        Book: Represents a book in the library.
                        User: Represents a library user.
                        Library: Manages the single book and single user.
             */ 
        }
    }
 
}
