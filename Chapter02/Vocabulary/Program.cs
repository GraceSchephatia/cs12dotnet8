using System.Reflection; // To use Assembly, TypeName, and so on.

/*// Declare some unused variables using types in additional assemblies to make them load too.
System.Data.DataSet ds = new();
HttpClient client = new();

Assembly? myApp = Assembly.GetEntryAssembly();

// If the previous line returned nothing then end the app.
if (myApp is null) return;

// Loop through the assemblies that my app references.
foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    // Load the assembly so we can read its details.
    Assembly a = Assembly.Load(name);
    // Declare a variable to count the number of methods.
    int methodCount = 0;
    // Loop through all the types in the assembly.
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // Add up the counts of all the methods.
        methodCount += t.GetMethods().Length;
    }
    // Output the count of types and their methods.
    WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);
}

// Naming things and assigning values
// Let the heightInMetres variable become equal to the value 1.88.
double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value { heightInMetres}.");*/

string fullNameWithTabSeparator = "Bob\tSmith";
Console.WriteLine(fullNameWithTabSeparator);

string filePath = @"C:\televisions\sony\bravia.txt";
Console.WriteLine(filePath);

string xml = """
<person age="50">
    <first_name>Mark</first_name>
</person>
""";

Console.WriteLine(xml);
/*using System; // A semicolon indicates the end of a statement.
using System.Linq;
using System.Collections.Generic;

namespace MyApp
{// An open brace indicates the start of a block.
    internal class Program
    {
        static void Main(string[] args)
        {
            //#error version

            //Console.WriteLine("Hello World!");
            WriteLine($"Computer named {Env.MachineName} says \"No.\"");

            #region Three variables that store the number 2 million.
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            #endregion

            // Outputs the current line terminator.
            // By default, this is a carriage-return and line feed.
            Console.WriteLine();
            // Outputs the greeting and the current line terminator.
            Console.WriteLine("Hello Ahmed");
            // Outputs a formatted number and date and the current line terminator.
            Console.WriteLine("Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);
        }
    }
} // A close brace indicates the end of a block.*/