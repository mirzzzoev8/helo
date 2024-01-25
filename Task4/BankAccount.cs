namespace Task4;

public class BankAccount
{
    int accountId;
    decimal balance;
    public string OwnerName;
    int isFrozen;
    public BankAccount(int id, decimal bal, string name)
    {
        accountId = id;
        balance = bal;
        OwnerName = name;
    }
    public void Deposit(decimal amount){
        balance+=amount;
    }
    public void Withdraw(decimal amount){
        balance-=amount;
    }
     public bool FreezeAccount()
    {
        isFrozen = true;
    }

    public void UnfreezeAccount()
    {
       isFrozen = false;
    }
}
