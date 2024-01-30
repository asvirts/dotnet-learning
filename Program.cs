var otto = new Pet("Otto");

Console.WriteLine(otto.Name);

public class Pet
{
    private string pet;

    public Pet(string pet)
    {
        this.pet = pet;
    }

    public string Name { get; set; }
}