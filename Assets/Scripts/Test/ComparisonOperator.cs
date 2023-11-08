using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*î‰ärââéZéq
        True: ê^
        False: ãU
        */
        int x = 8;
        int y = 0;

        string name1 = "naho";
        string name2 = "naho";



        Debug.Log(x == y); // false
        Debug.Log(x != y); // true
        Debug.Log(x > y); // false
        Debug.Log(x < y); // true
        Debug.Log(x >= y); // false
        Debug.Log(x <= y); // true
        Debug.Log(x > 5); // false
        Debug.Log(x >= 5); // true

        bool trueOrFalse = (x == y); //false
        if (trueOrFalse) // false
        {
            Debug.Log("xÇ∆yÇÕìôÇµÇ¢Ç≈Ç∑"); // falseÇÃÇΩÇﬂï\é¶Ç≥ÇÍÇ»Ç¢
        }

        trueOrFalse = (x != y);
        if (trueOrFalse) // true
        {
            Debug.Log("xÇ∆yÇÕìôÇµÇ≠Ç»Ç¢Ç≈Ç∑"); // trueÇÃÇΩÇﬂï\é¶Ç≥ÇÍÇÈ
        }

        //á@
        if (x > y)
        {
            Debug.Log("xÇÕyÇÊÇËëÂÇ´Ç¢");
        }

        //áA
        if (name1 == name2)
        {
            Debug.Log("ìÒÇ¬ÇÃñºëOÇÕìØÇ∂Ç≈Ç∑");
        }

        //áB
        int age = 0;
        if(age >= 20)
        {
            Debug.Log("ê¨êlÇ≈Ç∑");
        }
        else
        {
            Debug.Log("ñ¢ê¨îNÇ≈Ç∑");
        }
    }

}
