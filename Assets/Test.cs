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
        array[0] = 3;
        array[1] = 2;
        array[2] = 5;
        array[3] = 1;
        array[4] = 8;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);

        }
               

        // �z��v�f�̏��Ԃ𔽓]������
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);

        }
    }

   
// Update is called once per frame
void Update()
    {
      

          
        }
}
