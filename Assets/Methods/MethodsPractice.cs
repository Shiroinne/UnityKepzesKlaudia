using UnityEngine;
public class MethodsPractice : MonoBehaviour

{
    [SerializeField] float a; //oszt�lyv�ltoz�, field, mez�
    [SerializeField] float b;

    [Space]
    [SerializeField] float max;
    [SerializeField] float min;
    [SerializeField] float absoluteValueOfA;
    [SerializeField] float sign;
    [SerializeField] float pow;

    void OnValidate()
    {
        max = Mathf.Max(a, b);  //t�bb bemenetes f�ggv�nyek
        min = Mathf.Min(a, b);
        absoluteValueOfA = Mathf.Abs(a);   //egy bemenetes f�ggv�ny
        sign = Mathf.Sign(a);

        //Mathf.Sqrt square root
        //Mathf.Pow (alap, kitev�); tetsz�leges hatv�nyra emel�s; a kitev� is lehet float, nem csak az alap
        // a raised to the power of b

        pow = Mathf.Pow(a,b);
        // pl. 30^33 t�l nagy, a float m�r infinity-t fog ki�rni, nem tudja t�rolni
    }

    float Maximum(float a, float b)
    {
        /*float result;
          if (a > b)
              result = a;
          else
              result = b;

          return result;
        */

        if (a > b)
            return a;
        else
            return b;

      //return a > b ? a : b;
    }

    float AbsoluteValue(float a) //lok�lis v�ltoz�
    {
        if (a > 0)
            return a;
        else
            return -a;
        // return a >= 0? a : -a;

    }

    //oszt�lyon bel�l nem lehet ugyanaz a neve k�t v�ltoz�nak, fieldben szint�n; viszont f�ggv�gnyek lehet ugyanaz a v�ltoz� neve

    float Power(float base_, int exponent)
    {
        float result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= base_;
        }
        return result;
     
    }
}
