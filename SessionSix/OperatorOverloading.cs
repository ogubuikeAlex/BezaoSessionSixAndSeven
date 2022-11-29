namespace SessionSix.SessionSix
{
    internal class OperatorOverloading
    {
    }

    public class Token
    {
        string _name;
        string _symbol;
        double _value;

        public Token(string name, double value)
        {
            if (name.Length < 3)
            {
                throw new ArgumentException("Name must be at least three characters");
            }
            _name = name;
            _value = value;
            _symbol = name.Substring(0, 2);
        }

        //Overloading the addition operator
        public static Token operator +(Token one, Token two)
        {
            return new Token(one._name + two._name, two._value + one._value);
        }

        public static bool operator ==(Token one, Token two)
        {
            return !one._value.Equals(two._value);
        }

        public static bool operator !=(Token one, Token two)
        {
            return one._value.Equals(two._value);
        }

        public void Display()
        {
            Console.WriteLine($"\nName: {_name}");
            Console.WriteLine($"Symbol: {_symbol}");
            Console.WriteLine($"Value: {_value}\n");
        }
    }

    public class PlayGround
    {
        public static void Run()
        {
            Token tokenOne = new Token("Alexa", 1000000);
            tokenOne.Display();
            Token tokenTwo = new Token("Success", 200);
            tokenTwo.Display();

            Token tokenSum = tokenOne + tokenTwo;
            tokenSum.Display();

            bool isEqual = tokenOne == tokenSum;
            Console.WriteLine($"Is Equal: {isEqual}");
        }
    }
}
