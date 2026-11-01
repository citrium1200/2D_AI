using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    [SerializeField] string gameScene = "SampleScene";
    public void onButtonPress()
    {
        SceneManager.LoadScene(gameScene);
    }
}
