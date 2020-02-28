using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRifle
{
    float GetAccuracy();
    // GameObject GetGameObject();
}


public class BasicRifle: IRifle
{
    public float basicAccuracy = 5.0f;
    //public gameobject model

   // public basicRifle(Vector3 worldPos) { gameobject prefab = resource.load(); model = GameObject.Instantiate(prefab, worldPos, prefab.transform.roation); }

    public float GetAccuracy()
    {
        return basicAccuracy;
    }
}