using System.Diagnostics;  // To use Debug and Trace
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration; // To use ConfigurationBuilder.

string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt");

Console.WriteLine($"Writeline to: {logPath}");

TextWriterTraceListener logFile = new(File.CreateText(logPath));
Trace.Listeners.Add(logFile);

string settingsFile = "appsettigns.json";

string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);

Console.WriteLine("Processing: {0}", settingsPath);
Console.WriteLine("---{0} contents--", settingsFile);
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

Console.WriteLine($"Trace switch value is {ts.Value}");
Console.WriteLine($"Trace switch level: {ts.Level}");

Trace.WriteLine(ts.TraceError, "Trace error");
Trace.WriteLine(ts.TraceWarning, "Trace warning");
Trace.WriteLine(ts.TraceInfo, "Trace information");
Trace.WriteLine(ts.TraceVerbose, "Trace verbose");

// Close the text file (also flushes) and release resources.
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