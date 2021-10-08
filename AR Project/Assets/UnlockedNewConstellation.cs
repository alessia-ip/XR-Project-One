using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class UnlockedNewConstellation : MonoBehaviour
{

    public int StarsPulled = 0;

    public GameObject Unlocked;


    public ARTrackedImageManager trackedImg;
    public GameObject prefab;

    public UIText ui;
    
    // Update is called once per frame
    void Update()
    {
        if (StarsPulled >= 4)
        {
            Unlocked.SetActive(true);
            trackedImg.trackedImagePrefab = prefab;
            ui.MAX = 4;
        }  
    }
}
