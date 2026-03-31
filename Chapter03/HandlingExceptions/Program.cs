#region Wrapping error-prone code in a try block and Catching all exceptions
/*WriteLine("Before parsing");
Write("What's your age?");

string? input = ReadLine();

try
{
    *//* 
     * An exclamation mark ! after an expression is called the null-forgiving operator and it disables the compiler warning.
     * The null-forgiving operator has no effect at runtime.
     * If the expression could evaluate to null at runtime, perhaps because we assigned it in another way, then an exception would be thrown.
     *//*
    int age = int.Parse(input!);

    WriteLine($"You are {age} years old.");
}
*//*
 * Good Practice: Avoid over-catching exceptions.
 * They should often be allowed to propagate up the call stack to be handled at a level where more information is known about the
    circumstances that could change the logic of how they should be handled.
 *//*
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("After parsing");*/
#endregion

#region Catching with filters
//Write("Enter an amount: ");
//string amount = ReadLine()!;

//if (string.IsNullOrEmpty(amount)) return;

//try
//{
//    decimal amountValue = decimal.Parse(amount);
//    WriteLine($"Amount formatted as currency: {amountValue:C}");
//}
//catch (FormatException) when (amount.Contains("$"))
//{

//    WriteLine("Amounts cannot use the dollar sign!");
//}
//catch (FormatException)
//{
//    WriteLine("Amounts must only contain digits!");
//}
#endregion

#region Throwing overflow exceptions with the checked statement
/*try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
        x++;
        WriteLine($"After incrementing: {x}");
    }
}
catch (OverflowException)
{

    WriteLine("The code overflowed but I caught the exception.");
}*/
#endregion

#region Disabling compiler overflow checks with the unchecked statement

/*unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}*/

#endregion

#region Practicing and exploring: Exercise 3.1 – Test your knowledge
// 1. What happens when you divide an int variable by 0?
// It will cause a runtime or terminate the program.

// 2. What happens when you divide a double variable by 0?
// 3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
//4.What is the difference between x = y++; and x = ++y;?
//5. What is the difference between break, continue, and return when used inside a loop statement?
//6. What are the three parts of a for statement and which of them are required?
//7. What is the difference between the = and == operators?
//8. Does the following statement compile?
// for (; ; );
//9.What does the underscore _ represent in a switch expression?
//10. What interface must an object “implement” to be enumerated over by using the foreach statement ?
#endregion