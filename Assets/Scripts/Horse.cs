public class Horse : Character
{
    public Horse()
    {
        Name = "Horse";
    }

    public override void ShowDefaultMessage()
    {
        ShowMessage($"{Name}: Neigh, neigh!");
    }
}
