using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullStars : MonoBehaviour
{
    public GameObject dragMe;

    public float PosX;
    public float PosZ;
    
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
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Star")
                {
                    dragMe = hit.collider.gameObject;
                    PosX = dragMe.transform.position.x;
                    PosZ = dragMe.transform.position.z;
                }
            }
        } else if (touch.phase == TouchPhase.Ended)
        {
            dragMe = null;
        } else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
        {
            if (dragMe != null)
            {
                /*Debug.Log(Camera.main.ScreenToWorldPoint(touch.position));
                var NewY = Camera.main.ScreenToWorldPoint(touch.position).y;
                var NewBallPos = new Vector3(PosX, NewY, PosZ);
                dragMe.transform.position = NewBallPos;*/
                
                Vector3 touchPos = touch.position;
                Transform camTrans = Camera.main.transform;
                float dist = Vector3.Dot(dragMe.transform.position - camTrans.position, camTrans.forward);
                touchPos.z = dist;
                Vector3 pos = Camera.main.ScreenToWorldPoint(touchPos);
                var NewBallPos = new Vector3(PosX, pos.y, PosZ);

                dragMe.transform.position = NewBallPos;
            }
        }
    }
}
