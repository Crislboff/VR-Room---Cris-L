using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movementSpeed = 2.5f;
    
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       RaycastHit hit;
       if (Physics.Raycast(transform.position, transform.forward, out hit)){
            if (hit.transform.tag == "Waypoint"){
                targetPosition = new Vector3 (
                    hit.transform.position.x,
                    transform.position.y,
                    hit.transform.position.z);
            }
       } 
       transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }
}
