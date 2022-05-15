public class Chicken : Character // INHERITANCE
{
    public Chicken()
    {
        Name = "Chicken";
    }

    public override void ShowDefaultMessage() // POLYMORPHISM
    {
        ShowMessage($"{Name}: Cluck, cluck!");
    }
}
