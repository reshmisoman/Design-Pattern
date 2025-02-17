namespace SingletonPattern
{
    class TestLogger
    {
        static void Main()
        {
            //singleton
            Logger obj1 = Logger.Instance;
            Logger obj2 = Logger.Instance;
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            //non singleton
            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }
    }

    class Test
    {

    }

}
