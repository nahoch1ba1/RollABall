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
        DateTime now = DateTime.Now; // ���̎��Ԃ��擾����
        Debug.Log(now); // ���̎��Ԃ��Q�[���ɕ\������

    }

    
   
  

}
