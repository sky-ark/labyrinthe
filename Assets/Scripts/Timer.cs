using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    public TMP_Text chrono;
    private float timer;

    private float stopTime;

    private bool isRunning;
// Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        var minutes = timer / 60;
        var seconds = timer % 60;
        var fraction = (timer * 100) % 60;
        
        chrono.text = String.Format("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);

    }

    void StopTimer()
    {
        if (isRunning)
        {
            stopTime = timer;
        }
    }


}
// https://www.youtube.com/watch?v=Qxwqd2kMHbI Start Stop Reset a Timer