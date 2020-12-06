using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOppForward : MonoBehaviour
{
    private Rigidbody2D Rb;
    private float moveRightSpeed = 40f;

    // Start is called before the first frame update
    void Start()
    {
        Rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Count_Down.beginGame == true)
        {
            this.Rb.velocity = new Vector2(moveRightSpeed * Time.deltaTime, 0);
            Debug.Log(this.Rb.velocity);
        }
    }
}
