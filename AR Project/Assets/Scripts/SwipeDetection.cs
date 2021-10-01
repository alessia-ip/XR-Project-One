using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{

    public Vector2 touchPos;

    public CurrentlyActiveCardInBook _CurrentlyActiveCardInBook;

    public bool swiped = false;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 0)
        {
            return;
        }
        
        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            touchPos = touch.position;
        }
        if (touch.phase == TouchPhase.Moved && swiped == false)
        {
            var tempX = touch.position.x;
            if (touchPos.x - tempX > 1)
            {
                Debug.Log("left");
                //Camera.main.backgroundColor = Color.green;
                
                _CurrentlyActiveCardInBook.GetNewActive(-1);

            }
            if (touchPos.x - tempX < -1)
            {
                Debug.Log("right");
                //Camera.main.backgroundColor = Color.cyan;
                
                _CurrentlyActiveCardInBook.GetNewActive(1);
            }

            swiped = true;
        }

        if (touch.phase == TouchPhase.Ended)
        {
            touchPos = new Vector2(0,0);
            swiped = false;
        }

    }
}
