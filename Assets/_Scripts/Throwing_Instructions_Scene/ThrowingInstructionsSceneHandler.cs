using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ThrowingInstructionsSceneHandler: MonoBehaviour
{
    public void LoadTrashScannerScene()
    {
        SceneManager.LoadScene("AIScannerScene");
    }
    
    public void LoadOCRSceneScene()
    {
        SceneManager.LoadScene("OCRScene");
    }
}
