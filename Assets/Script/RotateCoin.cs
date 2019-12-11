﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public int rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if( other.gameObject.name == "Animasi"){
            Destroy(this.gameObject);
            GlobalScript.Instance.AddScoreA();
        }        
    }
}