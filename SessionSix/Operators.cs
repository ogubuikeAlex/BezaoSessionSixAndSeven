namespace SessionSix.SessionSix
{
    internal class Operators
    {

    }

    public class Calculator
    {
        long? _valueOne = 10;
        
        public long Add(long one, long two) => one + two;
        public long Subtract(long one, long two) => one - two;
        public long Modulo(long one, long two) => one % two;
        public bool Compare(long one, long two) => one > two;
        public long HandleNull(long one) => (_valueOne ?? one) * one;
        
        public void CheckType()
        {
            Type result = typeof(Calculator);
        }
    }
}
