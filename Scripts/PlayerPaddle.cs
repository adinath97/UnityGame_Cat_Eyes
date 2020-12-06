using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    public float padding = 1f;
    float xMin;
    float xMax;
    float yMin;
    float yMax;
    float newXPos;
    float newYPos;
    Vector2 screenPosition;
    Vector2 worldPosition;

    // Start is called before the first frame update
    void Start()
    {
        SetUpMoveBoundaries();
    }

    // Update is called once per frame
    void Update()
    {
        if(Count_Down.beginGame == true && Count_Down.gameOver == false)
        {
            MovePlayerBall();
        }
    }

    private void MovePlayerBall()
    {
        screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
        float mousePosInUnits = worldPosition.y;
        newYPos = Mathf.Clamp(mousePosInUnits, yMin, yMax);
        this.transform.position = new Vector2(transform.position.x, newYPos);
    }

    private void SetUpMoveBoundaries()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;

        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
    }
}
