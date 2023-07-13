using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamerControll : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public int m_score;
    bool m_isOver;
    UI m_UI;
    float power;
    void Start()
    {
        m_UI = FindObjectOfType<UI>();
        m_UI.textScore("Coin:" + m_score);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Reset()
    {

        m_score = 0;
        m_UI.textScore("Coin:" + m_score);

    }

    public void incrementSscore()
    {
        m_score++;
        m_UI.textScore("Coin:" + m_score);
    }
}
