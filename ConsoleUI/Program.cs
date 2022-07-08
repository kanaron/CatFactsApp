using CatFactsLib;

ApiLib.Initialize();

var fact = await CatFactProcessor.LoadFact();

Console.WriteLine(fact.Fact);
