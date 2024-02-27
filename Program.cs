static (string name, string surname, int age, int quantityOfPets, string[] nicknames, int quantityOfFavoriteColors, string[] favoriteColors) Survey()
{
    (string name, string surname, int age, int quantityOfPets, string[] nicknames, int quantityOfFavoriteColors, string[] favoriteColors) survey;
    Console.Write("Введите имя: ");
    survey.name = Console.ReadLine();

    Console.Write("Введите фамилию: ");
    survey.surname = Console.ReadLine();

    string inputAge;
    int intAge;
    do
    {
        Console.Write("Введите возраст: ");
        inputAge = Console.ReadLine();
    }
    while (CheckingValueCorrectEntered(inputAge, out intAge));

    survey.age = intAge;

    Console.Write("У вас есть домашний питомец? ");
    var HaveAPet = Console.ReadLine();

    if (HaveAPet == "да" || HaveAPet == "Да")
    {
        string inputQuantityOfPets;
        int intQuantityOfPets;
        do
        {
            Console.Write("Сколько у вас питомцев? ");
            inputQuantityOfPets = Console.ReadLine();
        }
        while (CheckingValueCorrectEntered(inputQuantityOfPets, out intQuantityOfPets));

        survey.quantityOfPets = intQuantityOfPets;

        Console.WriteLine("Как их зовут? ");

        survey.nicknames = NicknamesOfPets(survey.quantityOfPets);
    }
    else
    {
        survey.quantityOfPets = 0;
        survey.nicknames = NicknamesOfPets(survey.quantityOfPets);
    }

    string inputQuantityOfFavoriteColors;
    int intQuantityOfFavoriteColors;
    do
    {
        Console.Write("Сколько у вас любимых цветов? ");
        inputQuantityOfFavoriteColors = Console.ReadLine();
    }
    while (CheckingValueCorrectEntered(inputQuantityOfFavoriteColors, out intQuantityOfFavoriteColors));

    survey.quantityOfFavoriteColors = intQuantityOfFavoriteColors;

    survey.favoriteColors = FavoriteColors(survey.quantityOfFavoriteColors);

    return survey;
}

static string[] NicknamesOfPets(int quantityOfPets)
{
    var nicknames = new string[quantityOfPets];

    for (int i = 0; i < nicknames.Length; i++)
        nicknames[i] = Console.ReadLine();

    return nicknames;

}

static string[] FavoriteColors(int quantityOfFavoriteColors)
{
    string[] favoriteColors = new string[quantityOfFavoriteColors];

    Console.WriteLine("Какие? ");
    for (int i = 0; i < favoriteColors.Length; i++)
        favoriteColors[i] = Console.ReadLine();

    return favoriteColors;

}

static bool CheckingValueCorrectEntered(string value, out int intValue)
{
    if (int.TryParse(value, out int intNum) && intNum > 0)
    {
        intValue = intNum;
        return false;
    }
    else
    {
        intValue = 0;
        return true;
    }
}

static void ShowResult((string name, string surname, int age, int quantityOfPets, string[] nicknames, int quantityOfFavoriteColors, string[] favoriteColors) survey)
{
    // Вывод результатов опроса
    Console.WriteLine($"Имя: {survey.name}");
    Console.WriteLine($"Фамилия: {survey.surname}");
    Console.WriteLine($"Возраст: {survey.age}");

    if (survey.quantityOfPets > 0)
    {
        Console.WriteLine("Домашние питомцы:");
        for (int i = 0; i < survey.quantityOfPets; i++)
        {
            Console.WriteLine($"Питомец {i + 1}: {survey.nicknames[i]}");
        }
    }

    Console.WriteLine("Любимые цвета:");
    for (int i = 0; i < survey.quantityOfFavoriteColors; i++)
    {
        Console.WriteLine($"Цвет {i + 1}: {survey.favoriteColors[i]}");
    }

}

// Вызов функции опроса и вывод результатов
var surveyResult = Survey();
ShowResult(surveyResult);