using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnet : MonoBehaviour
{
    private Transform player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime);

        if (Movimiento.isMagnetic == true)
        {
            if (Vector3.Distance(transform.position,player.position) < 5) 
                transform.position = Vector3.MoveTowards(transform.position, player.position, 0.1f);
        }
    }

}
