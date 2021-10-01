using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchRopeMesh : MonoBehaviour
{
    public GameObject topPoint;
    public GameObject bottomPoint;
    
    // Update is called once per frame
    void Update()
    {
        var topPos = topPoint.transform.position;
        var bottomPos = bottomPoint.transform.position;
        var dist = Vector3.Distance(topPos, bottomPos);
        this.transform.localScale = new Vector3(
            this.transform.localScale.x,
            dist/2,
            this.transform.localScale.z
            );
    }
}
