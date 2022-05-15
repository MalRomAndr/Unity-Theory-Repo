using System.Collections;
using UnityEngine;

public class Farmer : Character
{
    public Farmer()
    {
        Name = "Emma";
    }

    public override void ShowDefaultMessage()
    {
        ShowMessage($"Hello, my name is {Name}");
    }
}
