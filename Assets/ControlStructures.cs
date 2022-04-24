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
        if (a % 2 == 0) //if mindig boolt vár; kisebb-nagyobb/egyenlõ tesztelések mindig a végén hajtódnak végre
        {
            parity = "páros";
        }
        else
        {
            parity = "páratlan"; //ha egy parancsból áll, nem muszáj kirakni a {}-t
        }

        /*UA.: 
        parity = a % 2 == 0 ? "Páros": "Páratlan";
        ez a feltételes operátor
        */

        if (a % 3 == 0)
            parity = "Maradék 0";
        else if (a % 3 == 1)
            parity = "Maradék 1";
        else
            parity = "Maradék 2";

        /* UA.:
         parity = $"Maradék {a % 3}";
        */
    }
}
