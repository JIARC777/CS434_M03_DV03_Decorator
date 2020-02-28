using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleClient : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic Accuracy: " + rifle.GetAccuracy());
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log("With Scope Accuracy: " + rifle.GetAccuracy());
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilzer(rifle));
            Debug.Log("With Stabilzer Accuracy: " + rifle.GetAccuracy());
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilzer(new WithDotSight(new WithLongBarrel(rifle))));
            Debug.Log("With Everything Accuracy: " + rifle.GetAccuracy());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithDotSight(rifle);
            Debug.Log("With Dot Sight Accuracy: " + rifle.GetAccuracy());
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithLongBarrel(rifle);
            Debug.Log("With Long Barrel Accuracy: " + rifle.GetAccuracy());
        }
    }
}
