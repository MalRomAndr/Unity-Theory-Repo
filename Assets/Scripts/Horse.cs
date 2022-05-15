public class Horse : Character // INHERITANCE
{
    public Horse()
    {
        Name = "Horse";
    }

    public override void ShowDefaultMessage() // POLYMORPHISM
    {
        ShowMessage($"{Name}: Neigh, neigh!");
    }
}
