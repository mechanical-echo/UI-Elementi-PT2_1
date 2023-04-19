using UnityEngine;
//To use scenes
using UnityEngine.SceneManagement;
public class AinuParsledzejs : MonoBehaviour
{
    public void GoToStart()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }

    public void GoToBean()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Stop()
    {
        Application.Quit();
    }
}
