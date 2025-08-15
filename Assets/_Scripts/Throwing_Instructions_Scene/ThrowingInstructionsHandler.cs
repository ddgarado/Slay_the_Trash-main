using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ThrowingInstructionsHandler: MonoBehaviour
{
    public Text trashTypeText;
    public Text trashBinsText;
    public RawImage trashTypeImage;
    public TextAsset trashRulesAsset;

    void Start()
    {
        string predictionPath = System.IO.Path.Combine(Application.persistentDataPath, "Prediction", "prediction.txt");
        string prediction = "";

        if (System.IO.File.Exists(predictionPath))
        {
            prediction = System.IO.File.ReadAllText(predictionPath).Trim().ToLower();
            trashTypeText.text = prediction;
        }
        else
        {
            trashTypeText.text = "Prediction not found.";
            Debug.LogWarning("Prediction file not found at: " + predictionPath);
            return;
        }

        // Show image
        LoadTrashTypeImage(prediction);

        // Show bin types
        if (trashRulesAsset == null)
        {
            trashBinsText.text = "No rules assigned.";
            Debug.LogWarning("No TextAsset assigned for trash rules.");
            return;
        }

        string[] lines = trashRulesAsset.text.Split(new[] { '\r', '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
        List<string> matchingBins = new List<string>();

        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            if (parts.Length == 2 && parts[0].Trim().ToLower() == prediction)
            {
                string binLabel = parts[1].Trim();
                if (!matchingBins.Contains(binLabel))
                {
                    matchingBins.Add(binLabel);
                }
            }
        }

        trashBinsText.text = matchingBins.Count > 0 ? string.Join(", ", matchingBins) : "No matching bins.";
    }

    void LoadTrashTypeImage(string prediction)
    {
        if (trashTypeImage == null) return;

        string imageName = prediction.Replace(" ", "_");
        Texture2D tex = Resources.Load<Texture2D>("TrashTypeImage/" + imageName);

        if (tex != null)
        {
            trashTypeImage.texture = tex;
        }
        else
        {
            Debug.LogWarning("Image not found in Resources/TrashTypeImage/: " + imageName);
        }
    }
}
