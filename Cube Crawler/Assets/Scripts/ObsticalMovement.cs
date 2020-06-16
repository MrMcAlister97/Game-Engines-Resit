using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalMovement : MonoBehaviour
{
    public float speed = 1; //speed can be ajustied from inspector 

    void Update()
    {
        if (gameObject.tag == "SpinningCW") // spins objects set with this tag to move clock wise
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * speed);
        }
        
        if (gameObject.tag == "SpinningCCW") // spins objects set with this tag to move counter clock wise
        {
            transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime * speed);
        }
    }
}
