using System.IO;
using UnityEngine;

public class SaveGameObjectState : MonoBehaviour
{
    private string savePath;

    private void Awake()
    {
        savePath = Path.Combine(Application.persistentDataPath, "gameObjectState.json");
        LoadState(); // Automatically load the state on awake
    }

    public void SaveState()
    {
        // Save the entire GameObject state including position, rotation, scale, and children
        GameObjectData data = new GameObjectData(GetComponent<RectTransform>());
        string json = JsonUtility.ToJson(data, true);

        File.WriteAllText(savePath, json);
        Debug.Log("Game object state saved to " + savePath);
    }

     public void LoadState()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            Debug.Log("Loaded JSON: " + json); // Log the JSON for debugging
            GameObjectData data = JsonUtility.FromJson<GameObjectData>(json);
            ApplyState(GetComponent<RectTransform>(), data);
            Debug.Log("Game object state loaded from " + savePath);
        }
        else
        {
            Debug.LogWarning("Save file not found at " + savePath);
        }
    }

    private void ApplyState(Transform parentTransform, GameObjectData data)
    {
        // Apply position, rotation, and scale
        parentTransform.position = data.position;
        parentTransform.rotation = data.rotation;
        parentTransform.localScale = data.scale;

        // Apply the state to child objects
        for (int i = 0; i < data.childData.Count; i++)
        {
            if (i < parentTransform.childCount)
            {
                ApplyState(parentTransform.GetChild(i), data.childData[i]);
            }
        }
    }
}
