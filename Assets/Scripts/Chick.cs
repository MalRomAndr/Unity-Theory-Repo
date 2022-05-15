public class Chick : Character // INHERITANCE
{
    public Chick()
    {
        Name = "Chick";
    }

    public override void ShowDefaultMessage() // POLYMORPHISM
    {
        ShowMessage($"{Name}: Cheep, cheep!");
    }
}
