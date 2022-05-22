// See https://aka.ms/new-console-template for more information
(string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;
var k = 0;
while(k<3)
{
    Console.WriteLine("Введите имя");
    string Name = Console.ReadLine();

    Console.WriteLine("Введите фамилию");
    string LastName = Console.ReadLine();

    Console.WriteLine("Введите логин");
    string Login = Console.ReadLine();

    int LoginLength = Login.Length;

    Console.WriteLine("Есть ли у вас животные? Да или Нет");

    var result = Console.ReadLine();

    if(result == "Да")
    {
        User.HasPet = true;
    }
    else
    {
        User.HasPet = false;
    }
    Console.WriteLine("Введите возраст пользователя");

    User.Age = double.Parse(Console.ReadLine());
    User.favcolors = new string[3];

    Console.WriteLine("Введите три любимых цвета пользователя");
    for(int i = 0; i < User.favcolors.Length; i++)
    {
        User.favcolors[i] = Console.ReadLine();
    }
    k++;
}
