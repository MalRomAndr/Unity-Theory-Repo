using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
