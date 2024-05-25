
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");

        Potato x = new Potato();

        Potato y = new Potato();

        y.name = "Nein";

        Console.WriteLine(x.name);
    }


    public class Potato
    {

        int age = 3;

        float weigth = 6f;

        public string name = "Jojo";


    }
}