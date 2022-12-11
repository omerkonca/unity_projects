using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float ucusGucu;
    private Rigidbody2D rb;
    public bool oyunBasladi, oyunBitti;


   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetMouseButtonDown(0))
        {
            if (!oyunBasladi)
            {
                rb.gravityScale = 1;
                oyunBasladi = true;
               
            }
            else
            {
                Uc();
            }
           
        }
    }

    public void Uc()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(new Vector2(0,ucusGucu));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="OlumAlani")
        {
            oyunBitti = true;
        }
    }
}
