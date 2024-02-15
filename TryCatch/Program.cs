public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Exception[] exceptions = new Exception[]
        {
            new DivideByZeroException("Попытка деления на ноль."),
            new InvalidOperationException("Недопустимая операция."),
            new IndexOutOfRangeException("Индекс за пределами диапазона."),
            new ArgumentException("Недопустимый аргумент."),
            new CustomException("Произошло пользовательское исключение.")
        };

        foreach (var exception in exceptions)
        {
            try
            {
                throw exception;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Поймано исключение: " + ex.GetType().Name + ". Сообщение: " + ex.Message);
            }
        }
    }
}
