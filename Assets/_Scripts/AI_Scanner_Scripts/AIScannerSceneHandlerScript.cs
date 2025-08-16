using UnityEngine;
using UnityEngine.SceneManagement;

public class AIScannerSceneHandlerScript : MonoBehaviour
{
    public CameraHandler cameraHandler; // Drag and drop this in the Inspector

    public void LoadMainMenuScene()
    {
        StopCameraIfRunning();
        SceneManager.LoadScene("MainMenuScene");
    }

    public void LoadThrowingInstructionsScene()
    {
        StopCameraIfRunning();
        SceneManager.LoadScene("ThrowingInstructionsScene");
    }

    private void StopCameraIfRunning()
    {
        if (cameraHandler != null)
        {
            Debug.Log("StopCamera func triggered");
            cameraHandler.StopCamera();
        }
    }
}
