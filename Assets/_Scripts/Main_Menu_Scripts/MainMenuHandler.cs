using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public void LoadScanScene()
    {
        SceneManager.LoadScene("ScanScene");
    }

    public void LoadCardCollectionScene()
    {
        SceneManager.LoadScene("CardCollectionScene");
    }
}
