using System;

class Program
{
    public static void Main()
    {
        List<BankAccount> bankAccounts = new List<BankAccount>()
        {
            new BankAccount(new Person("John", "Doe", 36, 343242), "23478d14jE", 780),
            new BankAccount(new Person("Mia", "Brown", 23, 348983), "2h325823b", 230),
            new BankAccount(new Person("Artem", "Krat", 18, 123891), "12052007wr", 15000)
        };
        
        Bank bank = new Bank(bankAccounts);
        
        while (true)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Hello there. Please, choose an option:\n1.Bank Account\n2.Bank management");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                {
                    Console.WriteLine("Sign in/Sign up:");
                    string input_1 = Console.ReadLine();
                    switch (input_1.ToUpper())
                    {
                        case "SIGN IN":
                        {
                            Console.WriteLine("Enter your passport number:");
                            
                            int nPassportNumber = int.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Enter password to your account");
                            
                            string nPassword = Console.ReadLine();
                            
                            BankAccount bankAccount = bank.GetAccounts().FirstOrDefault(b => b.GetOwner().GetPassportNumber() == nPassportNumber);

                            if (bankAccount == null)
                            {
                                Console.WriteLine("Sorry, but there is no bank account with than passport number.");
                                return;
                            }

                            if (bankAccount.GetPassword() == nPassword)
                            {
                                Console.WriteLine("You successfully entered into your account.");

                                while (true)
                                {
                                    Console.WriteLine("Available options:\n1.Display information\n2.Deposit into your account\n3.Withdraw money from your account\n4.Exit");
                                
                                    int aInput = int.Parse(Console.ReadLine());
                                    
                                    switch (aInput)
                                    {
                                        case 1:
                                        {
                                            bankAccount.ToString();
                                        }
                                            break;
                                        case 2:
                                        {
                                            Console.WriteLine("Enter how many you want to deposit:");
                                            
                                            int mAmount = int.Parse(Console.ReadLine());
                                            
                                            bankAccount.Deposit(mAmount);
                                            
                                            Console.WriteLine($"Currently deposit balance: {bankAccount.GetBalance()}$");
                                        }
                                            break;
                                        case 3:
                                        {
                                            Console.WriteLine("Enter amount of money you want to withdraw from your balance:");
                                            
                                            int nAmount = int.Parse(Console.ReadLine());
                                            
                                            bankAccount.Withdraw(nAmount);
                                            
                                            Console.WriteLine($"Currently deposit balance: {bankAccount.GetBalance()}$");
                                        }
                                            break;
                                        case 4:
                                        {
                                            Console.WriteLine("Quitting... Have a nice day");
                                            return;
                                        }
                                            break;
                                        default:
                                        {
                                            Console.WriteLine("Something went wrong. Please try to choose option again.");
                                        }
                                            break;
                                }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, but this password isn't correct for your account");
                            }
                        }
                            break;
                        case "SIGN UP":
                        {
                            Console.WriteLine("Enter your personal information - Name, Surname, Age and PassportNumber");
                            string nName = Console.ReadLine();
                            string nSurname = Console.ReadLine();
                            int nAge = int.Parse(Console.ReadLine());
                            int  nPassportNumber = int.Parse(Console.ReadLine());
                            
                            Person nPerson = new Person(nName, nSurname, nAge, nPassportNumber);
                            
                            Console.WriteLine("Right now, you need to create password to your account");

                            string password1;
                            string password2;
                            
                            do
                            {
                                
                                Console.WriteLine("Create password:");
                            
                                password1 = Console.ReadLine();
                            
                                Console.WriteLine("Confirm your password:");
                            
                                password2 = Console.ReadLine();

                                if (password1 != password2)
                                {
                                    Console.WriteLine("Passwords do not match. Try again.");
                                }
                                
                            } while (password1 != password2);
                            
                            BankAccount nBankAccount = new BankAccount(nPerson, password1);
                            
                            bank.AddAccount(nBankAccount);
                        }
                            break;
                        default:
                        {
                            Console.WriteLine("Something went wrong. Please try again.");
                        }
                            break;
                    }
                }
                    break;
                case 2:
                {
                    Console.WriteLine("Welcome, sir. Choose an option to manage your bank:\n1.Find bank account.\n2.Display all bank accounts");
                    
                    int bInput = int.Parse(Console.ReadLine());

                    switch (bInput)
                    {
                        case 1:
                        {
                            Console.WriteLine("Enter password number of account you want to search:");
                            
                            int bPassportNumber = int.Parse(Console.ReadLine());
                            
                            BankAccount bankAccount = bank.GetAccounts().FirstOrDefault(b => b.GetOwner().GetPassportNumber() == bPassportNumber);

                            if (bankAccount != null)
                            {
                                Console.WriteLine("Sorry, but there is no bank account with than passport number.");
                                return;
                            }
                            
                            bankAccount.ToString();
                        }
                            break;
                        case 2:
                        {
                            bank.DisplayAllAccounts();
                        }
                            break;
                        default:
                        {
                            Console.WriteLine("Something went wrong.");
                        }
                            break;
                    }
                }
                    break;
                default:
                {
                    Console.WriteLine("Something went wrong. Please try again.");
                }
                    break;
            }
        }
    }
}