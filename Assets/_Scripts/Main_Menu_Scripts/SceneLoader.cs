using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void LoadScanScene()
    {
        SceneManager.LoadScene("AIScannerScene");
    }

    public void LoadCardsScene()
    {
        SceneManager.LoadScene("CardCollectionScene");
    }
}
