using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public void LoadTrashScannerScene()
    {
        SceneManager.LoadScene("AIScannerScene");
    }

    public void LoadCardCollectionScene()
    {
        SceneManager.LoadScene("CardCollectionScene");
    }
}
