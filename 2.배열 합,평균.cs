using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        int[] arr = { 10, 20, 30, 40, 50 };  // 예제 배열
        int sum = 0;
        float avg = 0.0;
        //합
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        //평균
        if (arr.Length > 0)
        {
            avg = (float)sum / arr.Length;
        }

        Debug.Log("Sum = " + sum);
        Debug.Log("Average = " + avg);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}