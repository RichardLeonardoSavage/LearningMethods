namespace LearningMethods
{
    class Program
    {

        //this is a method
        static void Main(string[] args)
        {

            SayHi("John", 33, "Dunedin");
            SayHi("Joe" , 45, "Christchurch" );
            SayHi("Jim" , 27, "Nelson");
            Console.ReadLine();
           

        }

        

        //can pass practically any form of value through these methods and the method will be able to process it


        //this is also a method that has been called upon in the main method
        static void SayHi(string name, int age, string location)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " and are from " + location);
          
          
        }

       

    }
}