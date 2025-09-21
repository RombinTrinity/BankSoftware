class BankAccount
{
    private Person _owner;
    private string _password;
    private float _balance;

    public BankAccount(Person owner, string password, float balance)
    {
        _owner = owner;
        _password = password;
        _balance = balance;
    }

    public BankAccount(Person owner, string password)
    {
        _owner = owner;
        _password = password;
        _balance = 0;
    }
    
    public void Deposit(float amount)
    {
        _balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (_balance >= amount)
        {
            _balance -= amount;
        }
        else
        {
            Console.WriteLine("Sorry, you don't have that much money.");
        }
    }

    public void FeatureInterest(float featureInterestPercentage)
    {
        _balance += _balance * featureInterestPercentage;
    }
    
    public void ToString()
    {
        Console.WriteLine($"Current bank account information:");
        GetOwner().ToString();
        Console.WriteLine($"Money on deposit: {GetBalance()}$");
    }

    #region Getters

    public Person GetOwner()
    {
        return _owner;
    }

    public string GetPassword()
    {
        return _password;
    }
    
    public float GetBalance()
    {
        return _balance;
    }

    #endregion
    
}
