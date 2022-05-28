using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class binary : MonoBehaviour
{
    //Unfinished, DO NOT RUN


    [SerializeField] int num;
    [SerializeField] string binarry;
    
    void Update()
    {
        binarry = "";
        int n = num;

        int pow = 1;
        while (pow < n)
        {
            pow *= 2;
        }

        //pow / 2

        while (pow > 0)
        {
            binarry += "1";
            n -= pow;
        }
    }
    
}
