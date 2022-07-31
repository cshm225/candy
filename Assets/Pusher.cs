﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{

    // Start is called before the first frame update
    Vector3 startPosition;

    public float amplitude;
    public float speed;

    void Start()
    {
        startPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        float z = amplitude * Mathf.Sin(Time.time * speed);
        transform.localPosition = startPosition + new Vector3(0, 0, z);
    }
}
