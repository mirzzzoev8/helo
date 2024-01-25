using Task4;
BankAccount account = new BankAccount(1001, 5000.00m, "John Doe" );
account.Deposit(1000.00m);
account.Withdraw(200.00m);
account.FreezeAccount();
account.Deposit(500.00m); 
account.UnfreezeAccount();
account.Deposit(500.00m);