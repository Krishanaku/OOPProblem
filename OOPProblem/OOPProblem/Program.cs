namespace OOPProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ClassAndOBject...........................................
            //Console.WriteLine("OOP Concept Problem.....");
            ////Method.................................................
            //ClassName method= new ClassName(); // object
            //method.sum();
            //method.sub(56,40);
            //int multi=method.mul(25, 25);
            //Console.WriteLine("Multi of two number : "+multi);
            //Console.ReadLine();

            //Constructor................................
            //ConstructType construct = new ConstructType("Mustang", "Red", 1969);
            //ConstructType construct1 = new ConstructType(1001, "Shine");
            //construct1.DisplayConstructor();
            //Console.WriteLine(construct.color + " " + construct.year + " " + construct.model);

            //Enum..............................
            //Console.WriteLine(DayOfWeek.Monday);
            //int count = (int)DayOfWeek.Monday;
            //Console.WriteLine(count);
            ////Second enum
            //Colors favoriteColor = Colors.Blue;
            //Console.WriteLine(favoriteColor);
            //switch (favoriteColor)
            //{
            //    case Colors.Red:
            //        Console.WriteLine("Your favorite color is red!");
            //        break;
            //    case Colors.Green:
            //        Console.WriteLine("Your favorite color is green.");
            //        break;
            //    case Colors.Blue:
            //        Console.WriteLine("Your favorite color is blue.");
            //        break;
            //}
            //
            //Typecasting.....................
            Typecasting typecasting = new Typecasting();
            typecasting.TypeImplicit();
            typecasting.TypeExplicit();
        }
    }
}