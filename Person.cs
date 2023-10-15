namespace Curs6Prob4
{
    class Person
    { //oare e ok sa folosesc in continuare PascalCase ? e ceea ce folosesc la munca si la master si am vazut
        // ca ati amintit ca raspuns la o tema anterioara de folosirea CamelCase
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public int Age => CalculateAge();

        public Person(string lastName, string firstName, DateTime birthDate, string country, string county, string city, string street, string streetNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            Country = country;
            County = county;
            City = city;
            Street = street;
            StreetNumber = streetNumber;
        }

        private int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - BirthDate.Year;
            if (currentDate < BirthDate.AddYears(age)) age--;
            return age;
        }    
        static void Main()
        {
            
            Person person1 = new Person("Gheorghita", "Tudor", new DateTime(2000, 11, 29), "Romania", "VL", "RmVl", "Street1", "2");
            Person person2 = new Person("Gaitanaru", "Teodora", new DateTime(2000, 5, 29), "Romania", "Vl", "RmVl", "Stree2", "22");

            
            Console.WriteLine("Persoana 1:");
            Console.WriteLine($"Nume: {person1.LastName}");
            Console.WriteLine($"Prenume: {person1.FirstName}");
            Console.WriteLine($"Data nasterii: {person1.BirthDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Varsta: {person1.Age} ani");
            Console.WriteLine($"Adresa: {person1.Country}, {person1.County}, {person1.City}, {person1.Street}, {person1.StreetNumber}");
            Console.WriteLine();

            Console.WriteLine("Persoana 2:");
            Console.WriteLine($"Nume: {person2.LastName}");
            Console.WriteLine($"Prenume: {person2.FirstName}");
            Console.WriteLine($"Data nasterii: {person2.BirthDate.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Varsta: {person2.Age} ani");
            Console.WriteLine($"Adresa: {person2.Country}, {person2.County}, {person2.City}, {person2.Street}, {person2.StreetNumber}");
        }
    }

}