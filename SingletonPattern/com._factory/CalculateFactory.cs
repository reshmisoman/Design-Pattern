namespace SingletonPattern.com._factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;

            if(type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if (type.ToLower().Equals("substract"))
            {
                obj = new Substract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("Don't do anything");
            }
            return obj;
        }
    }
}
