using TrainProject;
void Likes()
{
    Console.WriteLine("Введите имена людей");
    string selectNames = Console.ReadLine();
    bool check = selectNames.All(Char.IsDigit);
    if (selectNames == "")
    {
        string[] names = selectNames.Split(new char[] { ' ' });
        names = null;
        Check.Likes(names);
    }
    else if (selectNames.First() == ' ')
    {
        string[] names = selectNames.Split(new char[] { ' ' });
        names = null;
        Check.Likes(names);
    }
    else
    {
        string[] names = selectNames.Split(new char[] { ' ' });
        Check.Likes(names);
    }
}

while (true)
{
    Likes();
}