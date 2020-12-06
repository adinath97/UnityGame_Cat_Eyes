using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public static bool ballDestroyed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        ScoreManager.stopCounting = true;
        Count_Down.gameOver = true;
        Destroy(other.gameObject);
        StartCoroutine(ItsOverRoutine());
    }

    IEnumerator ItsOverRoutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GAME_OVER_YOU_LOST");
    }
}
