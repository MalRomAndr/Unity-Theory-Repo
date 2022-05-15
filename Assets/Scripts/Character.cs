using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Character : MonoBehaviour
{
    public TextMeshProUGUI text;

    private string characterName;

    public string Name
    {
        get { return characterName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Debug.LogError("Name can not be empty");
            }
            characterName = value;
        }
    }

    public abstract void ShowDefaultMessage();

    protected void ShowMessage(string message)
    {
        if (text != null)
        {
            StartCoroutine(MessageCoroutine(message));
        }
    }

    private IEnumerator MessageCoroutine(string message)
    {
        text.text = message;
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        text.gameObject.SetActive(false);
    }
}
