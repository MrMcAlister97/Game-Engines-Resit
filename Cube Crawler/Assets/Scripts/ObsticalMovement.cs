﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticalMovement : MonoBehaviour
{
    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * speed);
    }
}
