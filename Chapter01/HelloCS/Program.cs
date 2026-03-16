// Revealing the namespace for the Program class

/*
 * ?? is the null-coalescing operator
 * If the namespace of Program is null, then return None!; otherwise, return the name.
 */

string name = typeof(Program).Namespace ?? "None";
Console.WriteLine($"Namespace: {name}");

throw new Exception();
int z;
