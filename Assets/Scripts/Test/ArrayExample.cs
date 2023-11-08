using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // 試験の点数を保存するための5つ容量のある配列を宣言
    int[] testScores = new int[5];

    List<int> testNum = new List<int>();




    // Start is called before the first frame update
    void Start()
    {
        //LIST
        testNum.Add(1); // リストの0番目の要素に1を追加(1)
        testNum.Add(2); // リストの1番目の要素に2を追加(1, 2)
        testNum.Add(3); // リストの2番目の要素に3を追加(1, 2, 3)
        Debug.Log(testNum[0]); //リストの最初の要素を取得（1）
        testNum.Remove(2); // リスト内の一致する要素を削除(1, 3)
        Debug.Log(testNum.Count); // リストの要素数を取得（この場合、2）


        // 配列に点数を代入
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;

        Debug.Log(testScores[1]); // 90

        //配列演習①
        int[] number = { 5, 8, 12, 7, 3 };
        Debug.Log(number[2]);

        //配列演習②
        string[] fruits = { "apple", "banana", "cherry", "elderberry" };
        Debug.Log(fruits[2]);

        //配列演習③
        int[] scores = { 78, 85, 90, 72, 88, 60 };
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        Debug.Log(sum);

        //LIST演習①
        List<int> listNumbers = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int listNumber in listNumbers)
        {
            Debug.Log(listNumber);
        }
        //LIST演習②
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple"};
        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }

        //LIST演習③
        List<string> listFruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Fig" };
        if(listFruits.Contains("Cherry"))
        {
            Debug.Log("Cherryが含まれている");
        }
        else
        {
            Debug.Log("Cherryが含まれていない");
        }
    }
}
