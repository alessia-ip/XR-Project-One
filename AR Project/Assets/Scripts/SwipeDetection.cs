using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{

    public Vector2 touchPos;

    public float inputLength;
    
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
        if (touch.phase == TouchPhase.Moved)
        {
            var tempX = touch.position.x;
            if (touchPos.x - tempX > 0.5)
            {
                Debug.Log("greater");
                Camera.main.backgroundColor = Color.green;
            }
            if (touchPos.x - tempX < -0.5)
            {
                Debug.Log("less");
                Camera.main.backgroundColor = Color.cyan;
            }
        }

        if (touch.phase == TouchPhase.Ended)
        {
            touchPos = new Vector2(0,0);
            inputLength = 0;
        }

    }
}
