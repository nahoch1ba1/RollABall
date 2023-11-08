using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // �����̓_����ۑ����邽�߂�5�e�ʂ̂���z���錾
    int[] testScores = new int[5];

    List<int> testNum = new List<int>();




    // Start is called before the first frame update
    void Start()
    {
        //LIST
        testNum.Add(1); // ���X�g��0�Ԗڂ̗v�f��1��ǉ�(1)
        testNum.Add(2); // ���X�g��1�Ԗڂ̗v�f��2��ǉ�(1, 2)
        testNum.Add(3); // ���X�g��2�Ԗڂ̗v�f��3��ǉ�(1, 2, 3)
        Debug.Log(testNum[0]); //���X�g�̍ŏ��̗v�f���擾�i1�j
        testNum.Remove(2); // ���X�g���̈�v����v�f���폜(1, 3)
        Debug.Log(testNum.Count); // ���X�g�̗v�f�����擾�i���̏ꍇ�A2�j


        // �z��ɓ_������
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;

        Debug.Log(testScores[1]); // 90

        //�z�񉉏K�@
        int[] number = { 5, 8, 12, 7, 3 };
        Debug.Log(number[2]);

        //�z�񉉏K�A
        string[] fruits = { "apple", "banana", "cherry", "elderberry" };
        Debug.Log(fruits[2]);

        //�z�񉉏K�B
        int[] scores = { 78, 85, 90, 72, 88, 60 };
        int sum = 0;
        foreach (int score in scores)
        {
            sum += score;
        }
        Debug.Log(sum);

        //LIST���K�@
        List<int> listNumbers = new List<int> { 1, 2, 3, 4, 5 };
        foreach (int listNumber in listNumbers)
        {
            Debug.Log(listNumber);
        }
        //LIST���K�A
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple"};
        for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }

        //LIST���K�B
        List<string> listFruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Fig" };
        if(listFruits.Contains("Cherry"))
        {
            Debug.Log("Cherry���܂܂�Ă���");
        }
        else
        {
            Debug.Log("Cherry���܂܂�Ă��Ȃ�");
        }
    }
}
