namespace OOPProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            //Value And Reference.......................
            ValueAndReference obj= new ValueAndReference();
            obj.valueType(); 
            //Reference..................................
            Person person_One= new Person();
            
            Person person_Two = person_One; // Creates a reference to person1
            Console.WriteLine(person_One.Name ="Krrish");
            Console.WriteLine(person_One.Age = 30);
            Console.WriteLine(person_Two.Age = 35);

            // create a new instance of the Person class
            Person person1 = new Person { Name = "John", Age = 30 };

            // assign the reference to the person1 object to person2
            Person person2 = person1;

            // update the name property of the person2 object
            person2.Name = "Jane";

            // the name property of the person1 object is also updated
            Console.WriteLine(person1.Name); // output: Jane



        }
    }
}