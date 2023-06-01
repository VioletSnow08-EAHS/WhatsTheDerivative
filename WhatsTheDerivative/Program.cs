// See https://aka.ms/new-console-template for more information

using org.mariuszgromada.math.mxparser;

License.iConfirmNonCommercialUse("My name to sign a license that says I'm not going to do anything with this");
Console.WriteLine("Welcome to \"What's the Derivative?\"!");
Console.WriteLine("Please enter an equation.");


var einput = Console.ReadLine();

Console.WriteLine("Thank you! What should \"X\" be?");

var xInput = new Argument("x = "+ Console.ReadLine());
var derivative = new Expression(einput, xInput);

mXparser.consolePrintln($"The Derivative is: {derivative.calculate()}");

Console.WriteLine("Press any key to exit.");  
Console.ReadKey();