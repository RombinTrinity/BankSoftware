using System.Collections.Generic;

class Bank
{
    private List<BankAccount> _accountsList;
    private float featureInterestPercentage;
    
    public Bank()
    {
        _accountsList = new List<BankAccount>();
        featureInterestPercentage = 0;
    }

    public Bank(List<BankAccount> accountsList)
    {
        _accountsList = accountsList;
        featureInterestPercentage = 0;
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

    public void FeatureInterest()
    {
        foreach (BankAccount account in GetAccounts())
        {
            account.FeatureInterest(GetFeatureInterestPercentage());
        }
    }
    
    #region Getters

    public List<BankAccount> GetAccounts()
    {
        return _accountsList;
    }

    public float GetFeatureInterestPercentage()
    {
        return featureInterestPercentage;
    }

    #endregion
    
    #region Setters

    public void SetAccontsList(List<BankAccount> accounts)
    {
        _accountsList = accounts;
    }

    public void SetFeatureInterestPercentage(float percentage)
    {
        featureInterestPercentage = percentage;
    }
    
    #endregion
}
