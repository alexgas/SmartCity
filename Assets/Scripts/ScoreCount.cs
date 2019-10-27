using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    // Start is called before the first frame update

    public Text text;
     

    void Start()
    {
        Global.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Global.score += Time.deltaTime;
        text.text = "" +Global.score;

        Debug.Log(Global.score);
    }

    
}
