Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша"){
    Console.Write("Опять ты? ");
    Console.WriteLine(username);
}
else{
    Console.Write("Привет! ");
    Console.WriteLine(username);
}


