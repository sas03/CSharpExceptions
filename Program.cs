using Exceptions;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            throwError(7);
        }
        catch(CustomException e)
        {
            Console.WriteLine(e.Message + " : " + e.DateTime);
        }
    }

    public static void throwError(int value)
    {
        if(value > 5)
        {
            throw new CustomException($"Number typed {value} can't be greater than 5");
        }
    }
}