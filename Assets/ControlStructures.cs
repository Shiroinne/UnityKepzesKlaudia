using UnityEngine;

public class ControlStructures : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] string parity;
    void Start()
    {
        /*int i = 1;
        int count = 0;
        while (count < 10)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Debug.Log(i);
                count++;
            }
            i++;
        }
       */
       for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }
    }
    void OnValidate()
    {
        /*
        if (a % 2 == 0) //if mindig boolt v�r; kisebb-nagyobb/egyenl� tesztel�sek mindig a v�g�n hajt�dnak v�gre
        {
            parity = "p�ros";
        }
        else
        {
            parity = "p�ratlan"; //ha egy parancsb�l �ll, nem musz�j kirakni a {}-t
        }

        /*UA.: 
        parity = a % 2 == 0 ? "P�ros": "P�ratlan";
        ez a felt�teles oper�tor
        */

        if (a % 3 == 0)
            parity = "Marad�k 0";
        else if (a % 3 == 1)
            parity = "Marad�k 1";
        else
            parity = "Marad�k 2";

        /* UA.:
         parity = $"Marad�k {a % 3}";
        */
    }
}
