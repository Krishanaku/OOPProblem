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
            //MathHelper overloding= new MathHelper();
            //Console.WriteLine(overloding.Add(5, 6));
            //Console.WriteLine(overloding.Add(5.3,6.6));
            //Console.WriteLine(overloding.Add(5, 6, 7));
            ////Overriding....
            //Giraffe overriding= new Giraffe();
            //overriding.Eat();
            //Lion overr = new Lion();
            //overr.Eat();
            BankAccount myAccount = new BankAccount("123456789", 1000);
            myAccount.Deposit(500);
            Console.WriteLine(myAccount.GetBalance());   

            bool success = myAccount.Withdraw(2000);
            if (success)
            {
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Withdrawal failed");
            }
            Console.WriteLine(myAccount.GetBalance());


            Persou person1 = new Persou();
            person1.Name = "John Doe";
            person1.Age = 30;
            Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");








        }
    }
}