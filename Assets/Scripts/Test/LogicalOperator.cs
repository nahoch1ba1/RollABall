using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperator : MonoBehaviour

{
    bool condition1 = true;
    bool condition2 = false;

    // Start is called before the first frame update
    void Start()
    {
        //CheckCondition();
        if (condition1 && condition2) // false
        {
            Debug.Log("ðŒ1‚ÆðŒ2‚Ítrue‚Å‚·"); // false‚Ì‚½‚ß•\Ž¦‚³‚ê‚È‚¢
        }
        if (condition1 || condition2) // true
        {
            Debug.Log("ðŒ1‚Ü‚½‚ÍðŒ2‚ªtrue‚Å‚·"); // true‚Ì‚½‚ß•\Ž¦‚³‚ê‚é
        }

        //‡@
        int a = 10;
        int b = 4;
        if (a >= 10 && a != 15 && b <= 5)
        {
            //ðŒ‚ð–ž‚½‚·ˆ—
        }

        //‡A
        bool isRaining = true;
        bool hasUmbrella = true;
        //‰J‚ª~‚Á‚Ä‚¢‚È‚¢A‚Ü‚½‚Í‰J‚ª~‚Á‚Ä‚¢‚é‚ªŽP‚ðŽ‚Á‚Ä‚¢‚éê‡
        if (!isRaining || (isRaining && hasUmbrella))
        {
            Debug.Log("‰Æ‚ðo‚éB");
        }
    }


        void CheckCondition()
        {
            // &&:˜_—ÏiANDj
            Debug.Log(condition1 && condition2);
            // ||:˜_—˜aiORj
            Debug.Log(condition1 || condition2);
            // !:”Û’èiNOTj
            Debug.Log(!condition1);
            // ^:”r‘¼“I˜_—˜aiXORj
            Debug.Log(condition1 ^ condition2);

        }        
    }
