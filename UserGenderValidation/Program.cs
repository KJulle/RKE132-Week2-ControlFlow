// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada oma sugu (m/f) ning perekonnanimi
//kasutajat tervitatakse "Welcome, Mr./Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}


