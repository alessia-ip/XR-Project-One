using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentlyActiveCardInBook : MonoBehaviour
{
    private int currentlyActive = 0;

    public List<GameObject> childCards = new List<GameObject>();

    // Update is called once per frame
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            childCards.Add(transform.GetChild(i).gameObject);
            Debug.Log(childCards[i].name);
        }
        SetActiveAndDeactive();
    }

    public void GetNewActive(int dir)
    {
        currentlyActive = currentlyActive + dir;
        //so +1 if a right swipe
        // + -1 if a left swipe
        
        //loop through the list
        if (currentlyActive < 0)
        {
            currentlyActive = childCards.Count - 1;
        } else if (currentlyActive > childCards.Count - 1)
        {
            currentlyActive = 0;
        }
        
        SetActiveAndDeactive();
    }

    public void SetActiveAndDeactive()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (i == currentlyActive)
            {
                childCards[i].SetActive(true);
            }
            else
            {
                childCards[i].SetActive(false);
            }
        }
    }

}
