using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigateCollection : MonoBehaviour
{
    public GameObject[] collection;

    private int currentDisplayNumber = 0;
    
    public void goleft()
    {
        currentDisplayNumber = currentDisplayNumber--;
        if (currentDisplayNumber < 0)
        {
            currentDisplayNumber = collection.Length;
        }
        
    }
    
}
