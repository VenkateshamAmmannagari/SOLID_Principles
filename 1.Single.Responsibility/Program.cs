// See https://aka.ms/new-console-template for more information
using _1.Single.Responsibility;

UserService userService = new UserService();
var email = Console.ReadLine();
var password = Console.ReadLine();
userService.Register(email, password);
Console.ReadLine();