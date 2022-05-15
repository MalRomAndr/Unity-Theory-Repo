public class Dog : Character // INHERITANCE
{
    public Dog()
    {
        Name = "Dog";
    }

    public override void ShowDefaultMessage() // POLYMORPHISM
    {
        ShowMessage($"{Name}: Woof, woof!");
    }
}
