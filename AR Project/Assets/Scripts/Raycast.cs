using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Raycast : MonoBehaviour
{

    public GameObject canvas;
    
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag.Contains("Card") && hit.collider != null)
            {
                canvas.SetActive(true);
            }
            else
            {
                canvas.SetActive(false);
            }
        } else
        {
            canvas.SetActive(false);
        }
    }
}
