using CatFactsLib.ApplicationProcessor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var host = Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
{
    services.AddTransient<IApplicationProcessor, ApplicationProcessor>();
}).Build();

var srv = ActivatorUtilities.CreateInstance<ApplicationProcessor>(host.Services);
srv.Initialize();


Console.WriteLine("CatFactApp");
Console.WriteLine("Application that gets random cat facts and saves it to CatFacts.txt file");
Console.WriteLine();

bool nextFact = true;
ConsoleKey keyPressed;

do
{
    try
    {
        Console.WriteLine("Random cat fact:");
        Console.WriteLine(await srv.GetFact());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
    }

    Console.WriteLine();
    Console.WriteLine("Do you want next cat fact? (y/n)");
    Console.WriteLine();

    keyPressed = Console.ReadKey(true).Key;
    if (keyPressed == ConsoleKey.Y)
    {
        nextFact = true;
    }
    else 
    {
        nextFact = false;
    }

} while (nextFact);

