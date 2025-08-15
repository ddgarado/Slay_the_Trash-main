using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CardCollectionSceneScript : MonoBehaviour
{
    public Text Cards; // Assign the legacy UI Text object in the Inspector

    void Start()
    {
        string folderPath = Path.Combine(Application.persistentDataPath, "Card_Collection");
        string filePath = Path.Combine(folderPath, "card_collection.txt");

        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Cards.text = string.IsNullOrWhiteSpace(content) ? "No cards collected yet." : content;
        }
        else
        {
            Cards.text = "No cards collected yet.";
            Debug.LogWarning("Card collection file not found at: " + filePath);
        }
    }
}
