using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRandomInMap1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    float countTime = 0, countTime1 = 0;
    int randomPosition, a = 1, quantity = 3;
    GameObject[] enemyCount;
    // Start is called before the first frame update
    public static class undying
    {
        public static bool isUndying = true;
        public static bool isPlaying = true;
    }

    public void RandomEnemy()
    {
        //toc do game
        Time.timeScale = 1;

        Instantiate(enemy, new Vector3(-3.1f, 4.4f, 0), Quaternion.identity);
        Instantiate(enemy, new Vector3(-0.3f, 4.5f, 0), Quaternion.identity);
        Instantiate(enemy, new Vector3(7.6f, 4.6f, 0), Quaternion.identity);
        a = 0;

        undying.isPlaying = true;
    }
    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemyCount.Length < quantity && a == 0)
        {
            countTime1 += Time.deltaTime;
            if(countTime1 > 1)
            {
                randomPosition = UnityEngine.Random.Range(0, 3);
                countTime1 = 0;
                if(randomPosition == 0)
                {
                    Instantiate(enemy, new Vector3(-3.1f, 4.4f, 0), Quaternion.identity);
                }
                else if(randomPosition == 1)
                {
                    Instantiate(enemy, new Vector3(-0.3f, 4.5f, 0), Quaternion.identity);
                }
                else if(randomPosition == 2)
                {
                    Instantiate(enemy, new Vector3(7.6f, 4.6f, 0), Quaternion.identity);
                }
            }
        }
        if(countTime > 10 && a == 0)
        {
            randomPosition = UnityEngine.Random.Range(0, 3);
            countTime = 0;
            quantity += 1;
            if(randomPosition == 0)
            {
                Instantiate(enemy, new Vector3(-3.1f, 4.4f, 0), Quaternion.identity);
            }
            else if (randomPosition == 1)
            {
                Instantiate(enemy, new Vector3(-0.3f, 4.5f, 0), Quaternion.identity);
            }
            else if (randomPosition == 2)
            {
                Instantiate(enemy, new Vector3(7.6f, 4.6f, 0), Quaternion.identity);
            }
        }
    }
}
