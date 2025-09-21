class Person
{
    private string _name;
    private string _surname;
    private int _age;
    private int _passportNumber;
    
    public Person(string name, string surname, int age, int passportNumber)
    {
        _name = name;
        _surname = surname;
        _age = age;
        _passportNumber = passportNumber;
    }

    public void ToString()
    {
        Console.WriteLine($"Full name: {GetName()} {GetSurname()}.\nAge: {GetAge()} years old.\nPassport Number: {GetPassportNumber()}.");
    }
    
    #region Getters

    public string GetName()
    {
        return _name;
    }

    public string GetSurname()
    {
        return _surname;
    }

    public int GetAge()
    {
        return _age;
    }

    public int GetPassportNumber()
    {
        return _passportNumber;
    }

    #endregion
    
}