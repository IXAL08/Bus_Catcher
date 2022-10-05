using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Parallax : MonoBehaviour
{ 
    public float depth = 1;
    private Movimiento _player;

    private void Awake()
    {
        _player = GameObject.Find("Player").GetComponent<Movimiento>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float realVelocity = _player.velocity.x / depth;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;

        if (pos.x <= -19f)
        {
            pos.x = 32f;
        }
        transform.position = pos;
    }
}
