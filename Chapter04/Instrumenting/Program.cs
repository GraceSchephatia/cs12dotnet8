using System.Diagnostics;  // To use Debug and Trace
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration; // To use ConfigurationBuilder.

#region Configuring trace listeners
string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writeline to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));
Trace.Listeners.Add(logFile);

string settingsFile = "appsettings.json";
string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);
Console.WriteLine("Processing: {0}", settingsPath);

Console.WriteLine("--{0} contents--", settingsFile);
Console.WriteLine(File.ReadAllText(settingsPath));
Console.WriteLine("----");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());

// Add the settings file to the processed configuration and make it
// mandatory so an exception will be thrown if the file is not found.

builder.AddJsonFile(settingsFile, optional: false, reloadOnChange: true);
IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "PackSwitch",
    description: "This switch is set via a JSON config.");

configuration.GetSection("PacktSwitch").Bind(ts);

Console.WriteLine($"Trace switch value is {ts.Value}");
Console.WriteLine($"Trace switch level: {ts.Level}");

Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace information");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");

int unitsInStock = 12;
LogSourceDetails(unitsInStock > 10);

// Close the text file (also flushes) and release resources.
// Once we close Debug and Trace, then write to them, NOTHING will happen!
Debug.Close();
Trace.Close();

Console.WriteLine("Press enter to exit.");
Console.ReadLine();

#if DEBUG
// Text writer is buffered, so this option calls
// Flush() on all listeners after writing.
Trace.AutoFlush = true;
#endif

//Debug.WriteLine("Debug says, I'm watching!");

//Trace.WriteLine("Trace says, I am watching!");
#endregion

