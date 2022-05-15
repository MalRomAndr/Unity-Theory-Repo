public class Chicken : Character
{
    public Chicken()
    {
        Name = "Chicken";
    }

    public override void ShowDefaultMessage()
    {
        ShowMessage($"{Name}: Cluck, cluck!");
    }
}
