namespace OOPProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Abstraction..................
            //Uog obj = new Uog();
            //obj.makeSound();

            //Polymorphism.................
            //Overloding.........................
            MathHelper overloding= new MathHelper();
            Console.WriteLine(overloding.Add(5, 6));
            Console.WriteLine(overloding.Add(5.3,6.6));
            Console.WriteLine(overloding.Add(5, 6, 7));
            //Overriding....
            Giraffe overriding= new Giraffe();
            overriding.Eat();
            Lion overr = new Lion();
            overr.Eat();
    






        }
    }
}