
public class BankAccount
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Deposit { get; set; }
    public BankAccount(string firstname, string lastname)
    {
        Firstname = firstname;
        Lastname = lastname;
    }
    public BankAccount(string firstname, string lastname, int deposit)
        : this(firstname, lastname) 
    {
        if (deposit != 0)
        {
            Deposit = deposit;
        }
    }
}

public class SecureBankAccount : BankAccount
{
    public int PassportRaqami { get; set; }
    public SecureBankAccount(string firstname, string lastname, int depozit)
        : base(firstname, lastname, depozit)
    {
    }

    public SecureBankAccount(string firstname, string lastname, int depozit, int passportRaqami)
        : this(firstname, lastname, depozit)
    {
        passportRaqami = PassportRaqami;
    }
}