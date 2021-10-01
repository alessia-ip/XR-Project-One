using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBottom : MonoBehaviour
{
    public GameObject bottomPoint;

    
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(bottomPoint.transform);
    }
}
