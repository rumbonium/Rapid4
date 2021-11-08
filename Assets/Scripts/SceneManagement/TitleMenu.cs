using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    // loads game level
    public void PlayGame() { SceneManager.LoadScene("LightingTest"); }
}
