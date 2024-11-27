using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameObjectData
{
    public Vector3 position;
    public Quaternion rotation;
    public Vector3 scale;
    public List<GameObjectData> childData = new List<GameObjectData>();

    // Parameterless constructor
    public GameObjectData() { }

    // Constructor with Transform
    public GameObjectData(Transform transform)
    {
        position = transform.position;
        rotation = transform.rotation;
        scale = transform.localScale;

        foreach (Transform child in transform)
        {
            childData.Add(new GameObjectData(child));
        }
    }
}
