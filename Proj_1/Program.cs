string name = "";
string mood = "";
string resp = "";

Console.WriteLine("What is your name?");
name = Console.ReadLine();

Console.WriteLine($"Hello {name}, how are you today?");
mood = Console.ReadLine();

Console.WriteLine($"Well, I am sorry/happy to hear that you are {mood}.");
Console.WriteLine("My creator didnt code in multiple responses I'm afraid");
Console.WriteLine("Do you judge him for that?");
Console.WriteLine("y/n");
resp = Console.ReadLine();

if(resp == "y"){
    Console.WriteLine("Well go fuck yourself, I have a life to live!");
}
else if(resp == "n"){
    Console.WriteLine("Cheers mate, I don't have the energy for this atm.");
}
else{
    Console.WriteLine("That was a yes or no question dumbass!");
}
Console.WriteLine("Press ENTER to close");
Console.ReadLine();