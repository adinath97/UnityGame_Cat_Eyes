using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{
    public GameObject ball;
    public GameObject pusher;

    private void Update()
    {
        Camera gameCamera = Camera.main;
        float ballYPos = ball.transform.position.y;
        float pusherXPos = pusher.transform.position.x;
        this.transform.position = new Vector2(pusherXPos+1f, ballYPos);
    }
}
