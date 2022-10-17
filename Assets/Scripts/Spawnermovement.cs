using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnermovement : MonoBehaviour
{
    public float amp, frecuent;
        private Vector3 init;
        void Start()
        {
            init = transform.position;
        }
    
        // Update is called once per frame
        void Update()
        {
            transform.position = new Vector3(init.x, Mathf.Sin(Time.time * frecuent) * amp + init.y);
        }
}
