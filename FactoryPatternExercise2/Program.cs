namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Please select a database type from the following: List, SQL, or Mongo");
            Console.WriteLine("(Note that if a valid database type is not selected, List will be selected by default.)");
            var databaseChoice = Console.ReadLine();
            IDataAccess printDetails = DataAccessFactory.GetDataAccessType(databaseChoice);
            printDetails.LoadData();
            printDetails.SaveData();
        }
    }
}
