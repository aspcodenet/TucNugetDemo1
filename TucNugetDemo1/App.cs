using Bogus;
using CoolFunctions;
using Humanizer;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

public class App
{
    //Console + Web som använder samma "coola" superfunktion
    // = Skapa en Class Library

    // Använda ANDRAS Class Libraries
    //Skillnad Class  Library vs Frameworks

    public void Run()
    {
        var faker2 = new Faker<Person>()
            .RuleFor(person => person.FirstName, faker => faker.Person.FirstName)
            .RuleFor(person => person.LastName, faker => faker.Person.LastName)
            .RuleFor(person => person.City, faker => faker.Address.City());


        string jsonText = File.ReadAllText("persons.json");
        var listOfPersons = JsonConvert.DeserializeObject<List<Person>>(jsonText);
        Console.WriteLine(listOfPersons.Count);

        //var listOfPersons = faker2.Generate(100).ToList();
        //var text = JsonConvert.SerializeObject(listOfPersons);
        //File.WriteAllText("persons.json", text);





        var faker = new Faker();
        var person = new Person();
        person.FirstName = faker.Person.FirstName;
        person.LastName= faker.Person.LastName;
        person.City = faker.Address.City();








        var lista = new List<Person>();
        while (true)
        {
            Console.WriteLine("1. Skapa");
            //Lägga in 100 till  i listam
            Console.WriteLine("2. Sök");
            //skriv in text - lista alla som har texten i namn eller city
        }




        var d1 = DateTime.Now;
        var d2 = new DateTime(2023, 3, 2, 4, 0, 0);
        TimeSpan span = d1 - d2;
        string s = span.Humanize();
        Console.WriteLine(s);
        


        //
        var salaryCalculator = new SalaryCalculator();
        int c = salaryCalculator.Calculate(52, 100);
    }
}