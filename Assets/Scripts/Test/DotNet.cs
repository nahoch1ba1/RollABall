using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DotNet : MonoBehaviour
{

    public Text DayText;
    public Text DayAddWeaktext;
    private void Start()
    {
        showTime();
        DayText.text = DateTime.Now.ToString();
        DayAddWeaktext.text = DateTime.Now.AddDays(7).ToString();
    }
    void showTime()
    {
        DateTime now = DateTime.Now; // ¡‚ÌŠÔ‚ğæ“¾‚·‚é
        Debug.Log(now); // ¡‚ÌŠÔ‚ğƒQ[ƒ€‚É•\¦‚·‚é

    }

    
   
  

}
