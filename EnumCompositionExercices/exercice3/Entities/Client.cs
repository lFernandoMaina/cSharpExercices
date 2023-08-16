class Client
{
    public String? Name { get; set; }
    public String? Email { get; set; }
    public DateTime BirthdayDate { get; set; }

    public Client()
    {

    }

    public Client(string name, string email, DateTime birthday)
    {
        Name = name;
        Email = email;
        BirthdayDate = birthday;
    }

    public override string ToString()
        {
            return Name 
                + ", (" 
                + BirthdayDate.ToString("dd/MM/yyyy") 
                + ") - " 
                + Email;
        }
}