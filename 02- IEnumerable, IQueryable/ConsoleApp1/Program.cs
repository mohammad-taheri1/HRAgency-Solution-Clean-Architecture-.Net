using ConsoleApp1;

// IEnumerable<string> list1;

// IQueryable<string> list2;

IEnumerable<Student> students = new List<Student>()
{
    new Student() { Id = 1 , Name = "Jonh Doe", Email = "john@tmail.com" , Age = 30 },
    new Student() { Id = 2, Name = "Michael Davis", Email = "michael@yahoo.com", Age = 27 },
    new Student() { Id = 3 , Name = "Mary Doe", Email = "mary@tmail.com" , Age = 26 },
    new Student() { Id = 4, Name = "David Lee", Email = "david@example.com", Age = 26 },
    new Student() { Id = 5 , Name = "Bill Jonatan" , Email = "bill@tmail.com", Age = 25},
    new Student() { Id = 6, Name = "Bob Williams", Email = "bob@example.com", Age = 32 },
};

foreach (var student in students)
{
   Console.WriteLine(student.ToString());
}


Console.ReadLine();