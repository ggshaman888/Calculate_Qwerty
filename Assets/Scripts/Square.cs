using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public float speed = 50.0f;
    public Rigidbody2D rb;
    private void Start()
    {

    }

    private void OnMouseDown()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    private void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
           // transform.Translate(translation: transform.right * speed * Time.deltaTime);
           rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // transform.Translate(translation: -transform.right * speed * Time.deltaTime);
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.W))
        {
 //           rb.velocity = new Vector2(speed, rb.velocity.x);
            transform.Translate(translation: transform.up * speed * 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
   //         rb.velocity = new Vector2(-speed, rb.velocity.x);
            transform.Translate(translation: -transform.up * speed * Time.deltaTime);
        }

    }
}
