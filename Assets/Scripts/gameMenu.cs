using UnityEngine;
using UnityEngine.SceneManagement;

public class gameMenu : MonoBehaviour
{
    [SerializeField] string retry = "SampleScene";
    [SerializeField] string mainMenu = "Main Menu";

    public void onRetryPressed()
    {
        SceneManager.LoadScene(retry);
    }

    public void onMainPressed()
    {
        SceneManager.LoadScene(mainMenu);
    }
}
