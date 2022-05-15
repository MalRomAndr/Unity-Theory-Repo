public class Chick : Character
{
    public Chick()
    {
        Name = "Chick";
    }

    public override void ShowDefaultMessage()
    {
        ShowMessage($"{Name}: Cheep, cheep!");
    }
}
