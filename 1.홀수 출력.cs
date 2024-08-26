using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        List<int> hollsu = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                hollsu.Add(i); 
            }
        }

        foreach (int num in hollsu)
        {
            Debug.Log(num);  
        }
        Debug.Log("구분선 --------------------------");

        int j = 0;

        while (j < 100)
        {
            if (j % 2 != 0)
            {   
                Debug.Log(j);
            }
            j++; 
        }

        Debug.Log("구분선 --------------------------");
        int k = 1;

        do
        {
            if (k % 2 != 0)
            {
                Debug.Log(k);
            }
            k++;
        } while (k < 100);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
