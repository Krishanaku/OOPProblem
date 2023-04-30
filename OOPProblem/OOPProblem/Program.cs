namespace OOPProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Inheritance.........
            //SuperStar Inheri = new SuperStar();
            //Inheri.Haritik();
            //Inheri.BollyModel();

            //Multilevel inheritance.....
            //Dog myDog = new Dog();
            //myDog.Eat();
            //myDog.Walk();
            //myDog.Bark();

            //hierarchical inheritance.........
            //ChildFirst first = new ChildFirst();
            //Console.WriteLine(first.FatherName());
            //Console.WriteLine(first.ChildDName());

            //ChildSecond second = new ChildSecond();
            //Console.WriteLine(first.FatherName());
            //Console.WriteLine(first.ChildDName());
            //Hybrid Inheritance....................
            Cylinder obj = new Cylinder();
            obj.Display();
            obj.Draw();
            obj.Fill();
            Console.ReadKey();



        }
    }
}