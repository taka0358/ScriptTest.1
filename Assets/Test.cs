using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
       
    
            // �v�f��5�̔z�������������
            int[] array = new int[5];

        // �z��̊e�v�f�ɒl��������
            array[0] = 7;
            array[1] = 1;
            array[2] = 5;
            array[3] = 3;
            array[4] = 8;

            // �z��̗v�f�����ׂĕ\������
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
