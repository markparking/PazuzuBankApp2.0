public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Account { get; set; }
    public decimal Balance { get; set; }
    public string Password { get; set; }

    public Customer()
    {
    }

    public Customer(string name, string email, string password, string account, decimal balance)
    {
        Name = name;
        Email = email;
        Password = password;
        Account = account;
        Balance = balance;
    }
    public string GenerateAccountNumber() // Ligesom i en rigtig bank :tm: <- watermark
    {
        Random rnd = new Random();
        string Account = "";

        for (int i = 0; i < 16; i++)
        {
            Account += rnd.Next(10).ToString();
        }
        return Account;
    }
}
