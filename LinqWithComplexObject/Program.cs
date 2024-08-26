
//Task: Given a list of Person objects, use LINQ to:
//Find all people whose name starts with 'A'.
//Find the oldest person.
//Group people by age.


using LinqWithComplexObject;

List<Person> list = new List<Person>
{
   new Person { Name = "Alice", Age = 30 },
   new Person { Name = "Bob", Age = 40 },
   new Person { Name = "Anna", Age = 25 },
   new Person { Name = "Charlie", Age = 35 }
};


//Find all people whose name starts with A
var result = list.Where(x => x.Name.StartsWith('A'));

//find the oldest person
var oldPerson = list.OrderByDescending(x => x.Age).FirstOrDefault();

//group people by age
var groupAge = list.GroupBy(x => x.Age);


Console.WriteLine(string.Join("," , result.Select(s=>s.Name)));
Console.WriteLine(oldPerson?.Name);
foreach (var group in groupAge)
{
    Console.WriteLine($" {group.Key}: {string.Join(", ", group.Select(p => p.Name))}");
}