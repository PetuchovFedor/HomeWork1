using HomeWork1;
class Program
{
    public static void Main(string[] args)
    {
        Point centerpoint = new Point
        {
            X = 10,
            Y = 10
        };
        try
        {
            Ellips ellipse = new (centerpoint, 15, 17);
            Console.WriteLine($"Длина эллипса: {ellipse.GetLength()}");
            Console.WriteLine($"Площадь эллипса: {ellipse.GetSquare()}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
