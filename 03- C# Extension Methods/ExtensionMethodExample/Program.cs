using ExtensionMethodExample;

IEnumerable<string> names = new List<string>()
 {
     "john", "roz", "ali", "maryam"
 };

//1 Simple Example
//MyExtensionMethods newInstance = new MyExtensionMethods();
//var result = newInstance.GetConcatResult(names);

//2 Static Example
//var result = MyExtensionMethods.GetConcatResult(names);

//3 Extension Method Example
var result = names.GetConcatResult();



Console.WriteLine(result);
Console.ReadLine();