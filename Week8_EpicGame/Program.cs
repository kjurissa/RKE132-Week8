//string[] heros = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo"};
//string[] villains = {"Voldemort", "Darth Vader","Joker", "Sauron", "Dracula" };

string folderPath = "C:\Users\Kärt Kristina\source\repos\Week8_EpicGame;
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heros = File.ReadAllLines(folderPath + heroFile);
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword" };


string hero = GetRandomValueFromArray(heros);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the World!");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}