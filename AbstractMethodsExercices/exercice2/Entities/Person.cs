abstract class Person
{
    public String? Name { get; set; }
    public double AnualIncome { get; set; }

    public Person() { }

    public Person(String name, double anualIncome)
    {
        Name = name;
        AnualIncome = anualIncome;
    }

    public abstract double Tax();
}