namespace ExtensionMethodExample
{
    public static class MyExtensionMethods
    {
        public static string GetConcatResult(this IEnumerable<string> names)
        {
            string result = "";
            foreach (var item in names)
            {
                result += $"_{item}";
            }
            result += "_";
            return result;
        }
    }
}
