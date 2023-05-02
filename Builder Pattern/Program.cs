using Builder_Pattern.Builder_Pattern;

namespace Builder_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder b1 = new BuilderSingle();
            IBuilder b2 = new BuilderMulti();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            Console.WriteLine(p1.Display());

            Console.WriteLine("-----------------------------------");

            director.Construct(b2);
            Product p2 = b2.GetResult();
            Console.WriteLine(p2.Display());
        }
    }
}