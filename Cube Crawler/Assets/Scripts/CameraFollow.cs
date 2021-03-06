﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    void LateUpdate() //use late update to avoid jitter
    {
        transform.position = target.position + offset;
    }
}
