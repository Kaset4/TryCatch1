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
        // Массив из пяти различных видов исключений
        Exception[] exceptions = new Exception[]
        {
            new DivideByZeroException("Попытка деления на ноль."),
            new InvalidOperationException("Недопустимая операция."),
            new IndexOutOfRangeException("Индекс за пределами диапазона."),
            new ArgumentException("Недопустимый аргумент."),
            new CustomException("Произошло пользовательское исключение.")
        };

        // Реализуем конструкцию TryCatchFinally с итерацией по каждому типу исключения
        foreach (var exception in exceptions)
        {
            try
            {
                // Генерируем исключение
                throw exception;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Поймано исключение: " + ex.GetType().Name + ". Сообщение: " + ex.Message);
            }
        }
    }
}