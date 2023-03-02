using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 300f;
    public int forceX, forceY;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rigi;
        rigi = GetComponent<Rigidbody2D>();
        float forceX = Random.value < 0.5f ? -1f : 1f;
        float forceY = Random.value < 0.5f ? -1f : 1f;
        rigi.AddForce(new Vector2(forceX, forceY) * speed);
       

    }

    public void ResetPosition()
    {
        GetComponent<Rigidbody>().velocity = Vector2.zero;
        GetComponent<Rigidbody>().position = Vector2.zero;
    }
}
