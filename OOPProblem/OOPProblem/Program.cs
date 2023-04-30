namespace OOPProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OOP Concept Problem.....");
            //Method.................................................
            ClassName method= new ClassName(); // object
            method.sum();
            method.sub(56,40);
            int multi=method.mul(25, 25);
            Console.WriteLine("Multi of two number : "+multi);
            Console.ReadLine();
        }
    }
}