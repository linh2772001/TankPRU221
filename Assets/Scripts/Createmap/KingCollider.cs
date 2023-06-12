using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KingCollider : MonoBehaviour
{
    int a = 3;
    public GameObject Summary;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bulletEnemy")
        {
            a -= 1;

            if (a == 0)
            {
                Summary.SetActive(true);
                //intruct.GameStatus.isGameRunning = false;
                Destroy(gameObject);
                Destroy(GameObject.FindGameObjectWithTag("Player"));
                Time.timeScale = 0;
            }
        }
    }
}
