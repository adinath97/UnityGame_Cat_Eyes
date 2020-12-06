using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkAI : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ball")
        {
            Destroy(this.gameObject);
        }
    }
}
