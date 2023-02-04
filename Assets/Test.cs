using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
       
    
            // 要素数5の配列を初期化する
            int[] array = new int[5];

        // 配列の各要素に値を代入する
            array[0] = 7;
            array[1] = 1;
            array[2] = 5;
            array[3] = 3;
            array[4] = 8;

            // 配列の要素をすべて表示する
            for (int i = 0; i < 5; i++)
            

            {
                Debug.Log(array[i]);
              
            }
    
       

        
    }














        // Update is called once per frame
        void Update()
    {
        
    }
}
