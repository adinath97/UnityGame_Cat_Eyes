using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject green;
    public GameObject lightBlue;
    public GameObject pink;
    float paddingO = 1f;
    public List<GameObject> obstacles;

    private void Start()
    {
        StartCoroutine(InstantiateObstacles());
    }

    IEnumerator InstantiateObstacles()
    {
        Camera gameCamera = Camera.main;
        float xMin1 = gameCamera.ViewportToWorldPoint(new Vector3(.2f, 0, 0)).x + paddingO;
        float xMax1 = gameCamera.ViewportToWorldPoint(new Vector3(.5f, 0, 0)).x - paddingO;

        float yMin1 = gameCamera.ViewportToWorldPoint(new Vector3(0, .2f, 0)).y + paddingO;
        float yMax1 = gameCamera.ViewportToWorldPoint(new Vector3(0, .8f, 0)).y - paddingO;
        float green1X = Random.Range(xMin1, xMax1);
        float green1Y = Random.Range(yMin1, yMax1);
        GameObject green1 = Instantiate(green, new Vector2(green1X, green1Y), Quaternion.identity);
        obstacles.Add(green1);

        yield return new WaitForSeconds(5f);
        float xMin2 = gameCamera.ViewportToWorldPoint(new Vector3(.3f, 0, 0)).x + paddingO;
        float xMax2 = gameCamera.ViewportToWorldPoint(new Vector3(.6f, 0, 0)).x - paddingO;

        float blue1X = Random.Range(xMin2, xMax2);
        float blue1Y = Random.Range(yMin1, yMax1);
        GameObject blue1 = Instantiate(lightBlue, new Vector2(blue1X, blue1Y), Quaternion.identity);
        obstacles.Add(blue1);
        float pink1X = Random.Range(xMin2, xMax2);
        float pink1Y = Random.Range(yMin1, yMax1);
        GameObject pink1 = Instantiate(pink, new Vector2(pink1X, pink1Y), Quaternion.identity);
        obstacles.Add(pink1);

        yield return new WaitForSeconds(5f);
        float xMin3 = gameCamera.ViewportToWorldPoint(new Vector3(.3f, 0, 0)).x + paddingO;
        float xMax3 = gameCamera.ViewportToWorldPoint(new Vector3(.7f, 0, 0)).x - paddingO;

        float blue3X = Random.Range(xMin3, xMax3);
        float blue3Y = Random.Range(yMin1, yMax1);
        GameObject blue3 = Instantiate(lightBlue, new Vector2(blue3X, blue3Y), Quaternion.identity);
        obstacles.Add(blue3);
        float pink3X = Random.Range(xMin3, xMax3);
        float pink3Y = Random.Range(yMin1, yMax1);
        GameObject pink3 = Instantiate(pink, new Vector2(pink3X, pink3Y), Quaternion.identity);
        obstacles.Add(pink3);
        float green3X = Random.Range(xMin3, xMax3);
        float green3Y = Random.Range(yMin1, yMax1);
        GameObject green3 = Instantiate(green, new Vector2(green3X, green3Y), Quaternion.identity);
        obstacles.Add(green3);

        yield return new WaitForSeconds(5f);
        float xMin4 = gameCamera.ViewportToWorldPoint(new Vector3(.3f, 0, 0)).x + paddingO;
        float xMax4 = gameCamera.ViewportToWorldPoint(new Vector3(.7f, 0, 0)).x - paddingO;

        float blue4X = Random.Range(xMin3, xMax3);
        float blue4Y = Random.Range(yMin1, yMax1);
        GameObject blue4 = Instantiate(lightBlue, new Vector2(blue4X, blue4Y), Quaternion.identity);
        obstacles.Add(blue4);
        float pink4X = Random.Range(xMin3, xMax3);
        float pink4Y = Random.Range(yMin1, yMax1);
        GameObject pink4 = Instantiate(pink, new Vector2(pink4X, pink4Y), Quaternion.identity);
        obstacles.Add(pink4);
        float green4X = Random.Range(xMin3, xMax3);
        float green4Y = Random.Range(yMin1, yMax1);
        GameObject green4 = Instantiate(green, new Vector2(green4X, green4Y), Quaternion.identity);
        obstacles.Add(green4);
        float blue4_1X = Random.Range(xMin3, xMax3);
        float blue4_1Y = Random.Range(yMin1, yMax1);
        GameObject blue4_1 = Instantiate(lightBlue, new Vector2(blue4_1X, blue4_1Y), Quaternion.identity);
        obstacles.Add(blue4_1);
    }
}
