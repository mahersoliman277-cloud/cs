// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a number");
string toutal= Console.ReadLine();
int toutal2= int.Parse(toutal);
if(toutal2>=17)
{
  Console.WriteLine("You win!");
}
else if(toutal2<=16 && toutal2>0)
{
  Console.WriteLine("thank you");
}
else
{
  Console.WriteLine("Game over");
}