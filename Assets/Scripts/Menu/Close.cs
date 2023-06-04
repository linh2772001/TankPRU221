using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Close : MonoBehaviour
{
    public GameObject close;
    // Start is called before the first frame update
    public void Closed()
    {
        //Clear Object selected
        EventSystem.current.SetSelectedGameObject(null);
        // Choose a new selected object
        EventSystem.current.SetSelectedGameObject(close);
    }
}
