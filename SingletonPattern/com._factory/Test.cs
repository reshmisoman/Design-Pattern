namespace SingletonPattern.com._factory
{
    class Test
    {
        static void Main()
        {
            double num1, num2;

            Console.WriteLine("Enter first number");
            string input = Console.ReadLine();

            bool result = Double.TryParse(input, out num1);
            if(!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Enter second number");
            input = Console.ReadLine();
            
            result = Double.TryParse(input, out num2);
            if(!result)
            {
                Console.WriteLine("Please enter a number");
                return;
            }

            Console.WriteLine("Enter Add, Substract or Divide");
            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());

            obj.Calculate(num1, num2);
        }
    }
}
