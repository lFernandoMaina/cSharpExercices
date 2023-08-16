class PhysicalPerson : Person
{
    public double HealthSpending { get; set; }

    public PhysicalPerson() { }

    public PhysicalPerson(String name, double anualIncome, double healthSpending) : base(name, anualIncome)
    {
        HealthSpending = healthSpending;
    }

    public override double Tax()
    {
        if (AnualIncome < 20000.0)
        {
            return AnualIncome * 0.15 - HealthSpending * 0.5;
        }
        else
        {
            return AnualIncome * 0.25 - HealthSpending * 0.5;
        }
    }
}
