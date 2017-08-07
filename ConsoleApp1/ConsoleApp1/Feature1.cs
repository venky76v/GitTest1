namespace ConsoleApp1
{
    public class Feature1
    {
        public string FirstName { get; set; } = "Venky";
        public string LastName { get; set; } = "Venkataraman";

        public string FullName => $"{FirstName} {LastName}";
    }
}
