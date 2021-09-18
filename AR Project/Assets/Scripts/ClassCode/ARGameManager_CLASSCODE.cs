using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.ARFoundation;

public class ARGameManager_CLASSCODE : MonoBehaviour
{
    
    //this is in charge of detecting Raycasts
    public ARRaycastManager _raycastManager;

    //When we raycast, we have a list of everything the raycast hits here to check against
    public List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    [SerializeField] GameObject cubePrefab;

    private GameObject spawnedObject;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnedObject = null;
    }

    // Update is called once per frame
    void Update()
    {

        //If no touches, don't do the rest!!
        if (Input.touchCount == 0)
        {
            return;
        }

        //Stores whatever the touch was
        Touch touch = Input.GetTouch(0);

        //every update the raycast manager is sending out a raycast when there is a touch
        //The raycast goes from the position we touch
        //we fill the raycastHits list with the things the raycast touches
        if (_raycastManager.Raycast(Input.GetTouch(0).position, raycastHits))
        {
            //We will also need to know what kind of touch it is: tap, hold, etc
            //file:///Applications/Unity/Hub/Editor/2020.3.17f1/Documentation/en/ScriptReference/TouchPhase.html
            if (touch.phase == TouchPhase.Began)
            { 
                //raycastHits[0].pose.position 
                //-> Where the point is in the worldspace that the raycast is going out to
                spawnedObject = Instantiate(cubePrefab, raycastHits[0].pose.position, Quaternion.identity);
            } 
            else if (touch.phase == TouchPhase.Moved)
            {
                //If we have a cube spawned, move it!
                if (spawnedObject != null)
                {
                        spawnedObject.transform.position = raycastHits[0].pose.position;
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                
            }
            
        }
    }
}
