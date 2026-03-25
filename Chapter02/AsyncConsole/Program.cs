HttpClient client = new();

HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");
WriteLine("Apple's home page has {0:N0} bytes.",
response.Content.Headers.ContentLength);

// 1. What statement can you type in a C# file to discover the compiler and language version?
// #error version

// 2. What are the two types of comments in C#?
// Single line comments
/* Multi line comments*/

// 3. What is the difference between a verbatim string and an interpolated string?

// Verbatim Strings interprets characters literally, ignoring most escape sequences and allowing multiple lines
// Purpose: Primarily used to preserve whitespace, line breaks, and characters like backslashes exactly as they appear in the source code.
// This is especially useful for file paths, XML, or HTML strings.
string filePath = @"C:\Users\John\Documents\file.tx";

// Interpolated Strings Denoted by a $ symbol before the opening double quote 
// Purpose: Provides a more readable way to format strings by allowing variables or expressions to be placed inline within curly braces ({}).
string name = "Mark";
int age = 30;
string message = $"My name is {name} and I am {age} years old.";
// The output is: My name is Mark and I am 30 years old.


// 4. Why should you be careful when using float and double values?
// they inherently provide approximate representations of most real numbers,
// leading to potential rounding errors and unexpected results in calculations