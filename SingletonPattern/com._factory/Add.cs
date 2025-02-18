namespace SingletonPattern.com._factory
{
    public class Add : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("a + b is {0}", a + b);
        }
    }
}
  