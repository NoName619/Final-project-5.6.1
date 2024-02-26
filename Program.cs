static (string name, string surname, int age, int quantityOfPets, string[] nicknames, int quantityOfFavoriteColors, string[] favoriteColors) Survey()
{
    (string name, string surname, int age, int quantityOfPets, string[] nicknames, int quantityOfFavoriteColors, string[] favoriteColors) survey;

    Console.Write("Введите имя: ");
    survey.name = Console.ReadLine();

    Console.Write("Введите фамилию: ");
    survey.surname = Console.ReadLine();

    string age;
    int intAge;
    do
    {
        Console.Write("Введите возраст: ");
        age = Console.ReadLine();
    }
    while (CheckingValueCorrectEntered(age, out intAge));

    survey.age = intAge;


    Console.Write("У вас есть домашний питомец? ");
    var HaveAPet = Console.ReadLine();

    if (HaveAPet == "да" || HaveAPet == "Да")
    {
        string quantityOfPets;
        int intQuantityOfPets;
        do
        {
            Console.Write("Сколько у вас питомцев? ");
            quantityOfPets = Console.ReadLine();
        }
        while (CheckingValueCorrectEntered(quantityOfPets, out intQuantityOfPets));

        survey.quantityOfPets = intQuantityOfPets;

        survey.nicknames = NicknamesOfPets(survey.quantityOfPets);
    }

    else
    {
        survey.quantityOfPets = 0;
    }

    string quantityOfFavoriteColors;
    int intQuantityOfFavoriteColors;
    do
    {
        Console.Write("Сколько у вас любимых цветов? ");
        quantityOfFavoriteColors = Console.ReadLine();
    }
    while (CheckingValueCorrectEntered(quantityOfFavoriteColors, out intQuantityOfFavoriteColors));

    survey.quantityOfFavoriteColors = intQuantityOfFavoriteColors;

    survey.favoriteColors = FavoriteColors(survey.quantityOfFavoriteColors);

    return survey;
}


static string[] NicknamesOfPets(int quantityOfPets)
{
    var nicknames = new string[quantityOfPets];

    Console.Write("Как их зовут? ");
    for (int i = 0; i < nicknames.Length; i++)
        nicknames[i] = Console.ReadLine();

    return nicknames;
}

static string[] FavoriteColors(int quantityOfFavoriteColors)
{
    string[] favoriteColors = new string[quantityOfFavoriteColors];

    Console.Write("Какие? ");
    for (int i = 0; i < favoriteColors.Length; i++)
        favoriteColors[i] = Console.ReadLine();

    return favoriteColors;
}

static bool CheckingValueCorrectEntered(string value, out int intValue)
{
    if (int.TryParse(value, out int intNum))
    {
            if (intNum > 0)
            {
                intValue = intNum;
                return false;
            }
    }
    {
        intValue = 0;
        return true;
    }
}

static void ShowResult(survey)
{
    
}