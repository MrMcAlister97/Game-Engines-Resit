using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalMovement : MonoBehaviour
{
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "SpinningCW")
        {
            transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * speed);
        }
        
        if (gameObject.tag == "SpinningCCW")
        {
            transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime * speed);
        }
    }
}
