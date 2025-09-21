using System.Collections.Generic;

class Bank
{
    private List<BankAccount> _accountsList;

    public Bank()
    {
        _accountsList = new List<BankAccount>();
    }

    public Bank(List<BankAccount> accountsList)
    {
        _accountsList = accountsList;
    }

    public void AddAccount(BankAccount account)
    {
        _accountsList.Add(account);
    }

    public void DisplayAllAccounts()
    {
        foreach (BankAccount account in GetAccounts())
        {
            account.ToString();
        }
    }

    #region Getters

    public List<BankAccount> GetAccounts()
    {
        return _accountsList;
    }

    #endregion
    
    #region Setters

    public void SetAccontsList(List<BankAccount> accounts)
    {
        _accountsList = accounts;
    }

    #endregion
}