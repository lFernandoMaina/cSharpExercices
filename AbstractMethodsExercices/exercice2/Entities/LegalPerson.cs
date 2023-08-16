class LegalPerson : Person
{
    public int NumberOfEmployees { get; set; }

    public LegalPerson()
    {
    }

    public LegalPerson(string name, double anualIncome, int numberOfEmployees)
        : base(name, anualIncome)
    {
        NumberOfEmployees = numberOfEmployees;
    }

    public override double Tax()
    {
        if (NumberOfEmployees > 10)
        {
            return AnualIncome * 0.14;
        }
        else
        {
            return AnualIncome * 0.16;
        }
    }
}