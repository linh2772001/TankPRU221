using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private int WaitSec;
    // private int WaitSecInt;//for text in game
    public Text text;
    public int Duration;
    public GameManagerScript managerScript;
    private void Start()
    {
        Being(Duration);
    }

    private void Being(int second)
    {
        WaitSec = second;
        StartCoroutine(FixedUpdate());
    }
    private IEnumerator FixedUpdate()
    {
        while (WaitSec > 0)
        {
            // WaitSec -= Time.fixedDeltaTime;
            // WaitSecInt = (int)WaitSec;
            text.text = $"{WaitSec / 60:00}:{WaitSec % 60:00}";
            WaitSec--;
            yield return new WaitForSeconds(1f);
        }

        OnEnd();
    }
    private void OnEnd()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 0f;
        managerScript.GameOver();
    }
}
