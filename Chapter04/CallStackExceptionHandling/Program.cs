using CallStackExceptionHandlingLib; // To use Processor.
using static System.Console;


WriteLine("In Main");
Alpha();

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    WriteLine("In Beta");
    try
    {
        Processor.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Caught this: {ex.Message}");
        throw; // will lose call stack information
        // throw ex; // will lose call stack information
    }
}

// Output distrinct montreal métropolitain
/* In Main
 * In Alpha
 * In Beta
 * In Gamma
 * In Delta
 * Bad file path
 */