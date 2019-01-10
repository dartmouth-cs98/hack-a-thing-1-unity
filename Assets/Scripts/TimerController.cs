using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public Text timerText;
    public int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IncreaseTimer", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void IncreaseTimer()
    {
        time = time + 1;
        timerText.text = "time: " + time.ToString();
    }
}
