namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            do {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("Which database would you like to use?");
                Console.WriteLine("Type: List");
                Console.WriteLine("Type: SQL");
                Console.WriteLine("Type: Mongo");

                userInput = Console.ReadLine();
                if (userInput != "list" && userInput != "SQL" && userInput != "Mongo")
                {
                    correctInput = false;
                    Console.WriteLine("Bad Input!");
                    Thread.Sleep(1000);
                }
            } while (!correctInput);

            Console.Clear ();

            IDataAccess database = DataAccessFactory.GetDataAccessType(userInput);

            database.SaveData();
            var products = database.LoadData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }
            
        }
    }
}
