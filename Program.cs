//Jeremy Lapham
//10-17-22 
//Adding numbers 
//This program will ask the user for two numbers and add them together
//Peer Reviwed By:

bool addingGame = true;
string endGame;
bool validNum1 = true;
bool validNum2 = true;
int needNumber1 = 0;
int needNumber2 = 0;

while(addingGame == true)
{
Console.WriteLine("I can add any two numbers you want me to. Type in end if you don't want to play");
Console.WriteLine("Choose any number.");

string numOne = Console.ReadLine();
validNum1 = Int32.TryParse(numOne, out needNumber1);

Console.WriteLine("Now choose a second number.");

string numTwo = Console.ReadLine();
validNum2 = Int32.TryParse(numTwo, out needNumber2);
if(validNum1 ==true && validNum2 == true)
{
     int total = needNumber1 + needNumber2;
     Console.WriteLine($"Your total is {total}");
}
else 
{
     Console.WriteLine("");
     Console.WriteLine("These aren't even numbers man.");
}
Console.WriteLine("");
Console.WriteLine("Do you want to play again? Type End to stop or type anything else to continue");
endGame = Console.ReadLine().ToLower();
if (endGame == "end")
{
     addingGame = false;
}
}
Console.WriteLine("Thank you for playing");
