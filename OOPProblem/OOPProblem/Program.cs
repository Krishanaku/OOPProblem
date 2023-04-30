namespace OOPProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Inheritance.........
            SuperStar Inheri = new SuperStar();
            Inheri.Haritik();
            Inheri.BollyModel();

            //Multilevel inheritance.....
            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Walk();
            myDog.Bark();


        }
    }
}