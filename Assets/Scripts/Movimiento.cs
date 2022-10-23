using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody2D _player;
    private SpriteRenderer _spriteRenderer;
    public Vector2 velocity;
    public static bool isMagnetic;
    public bool speedUp = true;
    public bool marcador = false;
    public float desaselerar = 0.01f;
    public float acelerar = 5f;
    public float maxacc = 5f;
    public bool isonground = true;
    public float distance = 0f;
    public float jumpforce = 5f;
    // Start is called before the first frame update

    public void Awake()
    {
        _player = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        isMagnetic = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground == true)
        {
            _player.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            isonground = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        isonground = true;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Coin")
        {
            Destroy(col.gameObject);
        }
        if (col.tag == "Magnet")
        {
            isMagnetic = true;
            Destroy(col.gameObject);
        }
    }

    void FixedUpdate()
    {
        if (velocity.x >= 30)
        {
            marcador = true;
            if (marcador == true)
            { 
                distance += velocity.x * Time.fixedDeltaTime;
            }
        }
        
        if (isonground)
        {
            if (speedUp && velocity.x <= 60)
            {
                velocity.x += acelerar * Time.fixedDeltaTime;
            }
            else
            {
                speedUp = false;
                velocity.x -= desaselerar;
            }
        }
    }
    
}
    
