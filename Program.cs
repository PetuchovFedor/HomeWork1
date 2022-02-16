using HomeWork1;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Ellips ellipse = new (15, 17);
            Console.WriteLine($"Длина эллипса: {ellipse.GetLength()}");
            Console.WriteLine($"Площадь эллипса: {ellipse.GetSquare()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
