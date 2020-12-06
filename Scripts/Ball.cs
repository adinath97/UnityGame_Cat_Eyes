using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float padding = 1f;
    private Rigidbody2D Rb;
    float randomFactor = .5f;
    int counter1;

    // Start is called before the first frame update
    void Start()
    {
        Rb = this.GetComponent<Rigidbody2D>();
        counter1 = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(Count_Down.beginGame == true && counter1 == 0)
        {
            Rb.velocity = new Vector2(-15f, 0);
            //Debug.Log(Rb.velocity);
            counter1++;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Vector2 velocityTweak = new Vector2(randomFactor, randomFactor);
        Rb.velocity += velocityTweak;
    }
}
