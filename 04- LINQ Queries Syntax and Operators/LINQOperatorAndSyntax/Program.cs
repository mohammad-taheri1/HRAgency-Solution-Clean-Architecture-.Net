// string collection
IList<string> books = new List<string>()
{
    "C# Tutorial",
    "VB.NET Tutorial",
    "Learn C++",
    "JavaScript Tutorial" ,
    "Java"
};


// LINQ Query Syntax
var querySyntaxResult1 = from bookItem in books
                                        where bookItem.Contains("Tutorial") 
                                        select bookItem;
var querySyntaxResult2 = from bookItem in books
                                          where bookItem.Contains("JavaScript")
                                          select bookItem;


// LINQ Method Syntax
var methodSyntaxResult1 = books.Where(book => book.Contains("Tutorial"));
var methodSyntaxResult2 = books.Where(book => book.Contains("Java"));



Console.ReadLine();