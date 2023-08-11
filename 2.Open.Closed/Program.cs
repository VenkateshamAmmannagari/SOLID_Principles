// See https://aka.ms/new-console-template for more information
using _2.Open.Closed;

Console.WriteLine("Please enter actual price to discounted price as per customer type..!");
decimal actualPrice =Convert.ToInt64(Console.ReadLine());
ICustomerDiscount customerDiscount = new GoldCustomer();

//CustomerDiscount customerDiscount = new BronzeCustomer();
var total = customerDiscount.CustomerPrice(actualPrice);
Console.WriteLine($"Actual price is {actualPrice} INR and after discount the Final price is {total} INR");
Console.ReadLine();