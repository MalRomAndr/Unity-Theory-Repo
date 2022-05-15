public class Dog : Character
{
    public Dog()
    {
        Name = "Dog";
    }

    public override void ShowDefaultMessage()
    {
        ShowMessage($"{Name}: Woof, woof!");
    }
}
