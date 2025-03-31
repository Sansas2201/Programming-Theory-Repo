using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreen : MonoBehaviour
{
    public void LaunchGame()
    {
        SceneManager.LoadScene(1);
    }
}
