#region Looping with the while statement
/*int x = 0;
while (x < 10)
{
    Console.WriteLine(x);
    x++;
}*/
#endregion

#region Looping with the do statement
/*string? actualPassword = "Pa$$w0rd";
string? password;
string? attempt;

do
{
    Console.WriteLine("Enter your password: ");
    password = Console.ReadLine();
}
while (password != actualPassword);

Console.WriteLine("Correct!");*/
#endregion

#region Looping with the for statement
//for (int y = 1; y <= 10; y++)
//{
//    WriteLine();
//}

//for (int y = 0; y <= 10; y += 3)
//{
//    WriteLine(y);
//}

string[] names = { "Adam", "Barry", "Charlie" };


foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };
for (int i = 0; i < names2.Length; i++)
{
    WriteLine($"{names[i]} at position {i}.");
}
#endregion