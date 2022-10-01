// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutaja vanust
//kui kasutaja vanus on <13, siis konsoolis kuvatakse
//"You are too young to use Instragram"
//muul juhul kuvatakse "Welcome to Instagram"

Console.WriteLine("Please enter your age:");
int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram.");
}

else
{
    Console.WriteLine("You are too young to use Instragram.");
}
