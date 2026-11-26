namespace Interfaces
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o = new Class1();

            //method 1 
            o.Insert();
            o.Delete();
            o.Update();
            o.Display();

            //method 2
            IDbFunctions oIDb;
            oIDb = o;
            oIDb.Insert();
            oIDb.Update();
            oIDb.Delete();

            //method 3
            ((IDbFunctions)o).Insert();

            //method 4
            (o as IDbFunctions).Insert();

        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Delete()
        {
            Console.WriteLine("Idb.Delete from Class1");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from Class1");
        }

        public void Update()
        {
            Console.WriteLine("Idb.Update from Class1");
        }
    }
}


namespace Interfaces2
{
    internal class Program
    {
        static void Main2()
        {
            Class1 o = new Class1();

            //method 1 
            //o.Delete();
            o.Open();

            IFileFunctions oIFile;
            oIFile = o;
            oIFile.Delete();

            (o as IFileFunctions).Delete();
            (o as IDbFunctions).Delete();

        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }

    public class Class1 : IDbFunctions, IFileFunctions
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        void IDbFunctions.Delete()
        {
            Console.WriteLine("Idb.Delete from Class1");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from Class1");
        }

        public void Update()
        {
            Console.WriteLine("Idb.Update from Class1");
        }

        //void IFileFunctions.Open()
        //{
        //    Console.WriteLine("IFile.Open from Class1");
        //}

        //void IFileFunctions.Close()
        //{
        //    Console.WriteLine("IFile.Close from Class1");
        //}

        void IFileFunctions.Delete()
        {
            Console.WriteLine("IFile.Delete from Class1");
        }

        public void Open()
        {
            Console.WriteLine("IFile.Open from Class1");
        }

        public void Close()
        {
            Console.WriteLine("IFile.Close from Class1");
        }
    }
}


namespace Interfaces3
{
    internal class Program
    {
        static void Main1()
        {
            Class1 o1 = new Class1();
            Class2 o2 = new Class2();

            IDbFunctions oIDb;

            oIDb = o1;
            oIDb.Insert();

            oIDb = o2;
            oIDb.Insert();
        }

        static void Main()
        {
            Class1 o1 = new Class1();
            Class2 o2 = new Class2();

            InsertObject(o1);
            InsertObject(o2);

        }
        static void InsertObject(IDbFunctions oIDb)//oIDb = o2
        //can receive an object of any class that implements IDbFunctions
        {
            oIDb.Insert();
        }
    }

    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class1 : IDbFunctions
    {
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Delete()
        {
            Console.WriteLine("Idb.Delete from Class1");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from Class1");
        }

        public void Update()
        {
            Console.WriteLine("Idb.Update from Class1");
        }
    }

    public class Class2 : IDbFunctions
    {
        public void Show()
        {
            Console.WriteLine("Show");
        }
        public void Delete()
        {
            Console.WriteLine("Idb.Delete from Class2");
        }

        public void Insert()
        {
            Console.WriteLine("Idb.Insert from Class2");
        }

        public void Update()
        {
            Console.WriteLine("Idb.Update from Class2");
        }
    }
}
//advantages of interfaces

//contract - class MUST implement all the interface methods
//similar code in entire project for all developers
//polymorphic code
//design patterns 

//to do - 
// try inheritance in interfaces
//I1{...} I2:I1{...}

