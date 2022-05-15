using System.Collections;
using UnityEngine;

public class Farmer : Character // INHERITANCE
{
    public Farmer()
    {
        Name = "Emma";
    }

    public override void ShowDefaultMessage() // POLYMORPHISM
    {
        ShowMessage($"Hello, my name is {Name}");
    }
}
