namespace Day_3
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            cls1 o = new cls1();
            o.Insert();
            o.Delete();
            o.Update();

            o.Display();

            //(o as IDfunction).insert();

        }

    }
    public abstract class abs_cls
    {
        public void insert()
        {
            Console.WriteLine("insert method in abstract");
        }
        public virtual void Update()
        {
            Console.WriteLine("update method from abstract");
        }
        public virtual void Delete()
        {
            Console.WriteLine("delete method from abstract");
        }
    }


    //public class cls1:IDfunction

    //{
    //    public  void Insert()
    //    {
    //        Console.WriteLine("cls insert mtd");
    //    }

    //    void IDfunction.Delete()
    //    {
    //        Console.WriteLine("cls delete mtd");

    //    }
    //    void IDfunction.Update()
    //    {
    //        Console.WriteLine("cls update");
    //    }
    //}
    public class cls1 : abs_cls
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public override void Delete()
        {
            Console.WriteLine("Idb.Delete from Class1");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from Class1");
        }

        public override void Update()
        {
            Console.WriteLine("Idb.Update from Class1");
        }
    }


    public interface Interface2
    {
        public static void Main2()
        {
            cls3 o = new cls3();
            //o.Insert();
            //method - 2
            (o as IDfunction).Insert(); //calling the cls3 insert method

            //method - 3
            IDfunction idf;
            idf = o;
            idf.Delete();

            //method - 4
            ((IDfunction)o).Update();

            cls4 o1 = new cls4();
            o1.disp();

        }
        public interface IDfunction
        {
            void Insert();
            void Update();
            void Delete();

        }
        public class cls3 : IDfunction
        {
            void IDfunction.Delete()
            {
                Console.WriteLine("cls3 delete method ");
            }

            void IDfunction.Insert()
            {
                Console.WriteLine("cls 3 insert mtd");
            }

            void IDfunction.Update()
            {
                Console.WriteLine("cls 3 update method");
            }
        }

    }
    public abstract class abs_class
    {
        public int i = 10;

    }
    public interface Intr
    {
        static int i = 10;
        //int i = 10;

    }
    public class cls4 : abs_class
    {

        public void disp()
        {
            Console.WriteLine(" " + i);
        }
    }
    //degfault implementation 
    // situation - 1
    public interface IDbFunctions1
    {
        void Insert();
        void Update();
        void Delete();

        void Select()
        {
            Console.WriteLine("def impl of Select");//default implementation 
        }
    }
    public class cls5 : IDbFunctions1
    {
        public void Delete()
        {
            Console.WriteLine("delete method");

        }

        public void Insert()
        {
            Console.WriteLine("insert method");

        }

        public void Update()
        {
            Console.WriteLine("updtae method");
        }
        //public void Select() { } //not reuqire to write

        public static void Main1()
        {
            cls5 po = new cls5();
            //po.Select(); not avialable from cls5
            (po as IDbFunctions1).Select();
            (po as IDbFunctions1).Update();

        }

        //situation 2 
        //degfault implementation 
        // class write code for select 
        public interface IDbFunctions2
        {
            void Insert();
            void Update();
            void Delete();

            void Select()
            {
                Console.WriteLine("def impl of Select");//default implementation 
            }
        }
        public class cls6 : IDbFunctions2
        {
            public void Delete()
            {
                Console.WriteLine("delete method");

            }

            public void Insert()
            {
                Console.WriteLine("insert method");

            }

            public void Update()
            {
                Console.WriteLine("updtae method");
            }
            public void Select()
            {
                Console.WriteLine("slect method from class ");
            }

            public static void Main3()
            {
                cls6 po = new cls6();
                po.Select();//  avialable from cls5
                (po as IDbFunctions2).Select(); //available from class 
                //(po as IDbFunctions1).Update();

            }
            //situation 3 : class implements more than one interface and some methods are same
            //class writes code for Select() using explicit implementation

            public interface IDbFunctions1
            {
                void Insert();
                void Update();
                void Delete();

                void Select()
                {
                    Console.WriteLine("default impl of Select");//default implementation 
                }
            }
            public interface IDbFunctions2
            {
                void Insert();
                void Update();
                void Delete();

                void Select()
                {
                    Console.WriteLine("default impl of Select");//default implementation 
                }
            }
            public class cls7 : IDbFunctions1, IDbFunctions2
            {
                public void Delete()
                {
                    Console.WriteLine("delete method");

                }

                public void Insert()
                {
                    Console.WriteLine("insert method");

                }
                public void Update()
                {
                    Console.WriteLine("updtae method");
                }
                public void Select()
                {
                    Console.WriteLine("select method from class ");
                } //not reuqire to write

                public static void Main()
                {
                    cls7 po = new cls7();
                    //po.Select(); not available from cls5
                    (po as IDbFunctions1).Select();
                    //(po as IDbFunctions1).Update();

                }
            }

        }
    }
}

//interfaces can contain methods, properties, static members
//cannot contain non static data