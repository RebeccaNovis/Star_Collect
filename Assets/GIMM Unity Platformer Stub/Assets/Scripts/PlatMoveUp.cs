using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatMoveUp : MonoBehaviour
{
    public float direction, timer;

    public bool moving;

    public void Start()
    {
        direction = 0.1f;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moving = true;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moving = false;
        }
    }
    public void FixedUpdate()
    {
        if (moving == true)
        {
            timer += Time.deltaTime;
            transform.Translate(Vector3.up * direction);
            if (timer >= 1)
            {
                direction *= 0;
                timer = 0;
            }
        }
    }
}