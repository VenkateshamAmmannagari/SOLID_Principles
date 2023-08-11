// See https://aka.ms/new-console-template for more information
using _5.DependencyInversion;

//Ilog log = new FileLogger();
//var productService = new ProductService(log);
//productService.Log("Depenency Inversion");
ProductService productService = new ProductService();
productService.LogToFile("Depenency Inversion");
Console.ReadLine();