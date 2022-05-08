using UnityEngine;
public class MethodsPractice : MonoBehaviour

{
    [SerializeField] float a; //osztályváltozó, field, mezõ
    [SerializeField] float b;

    [Space]
    [SerializeField] float max;
    [SerializeField] float min;
    [SerializeField] float absoluteValueOfA;
    [SerializeField] float sign;
    [SerializeField] float pow;

    void OnValidate()
    {
        max = Mathf.Max(a, b);  //több bemenetes függvények
        min = Mathf.Min(a, b);
        absoluteValueOfA = Mathf.Abs(a);   //egy bemenetes függvény
        sign = Mathf.Sign(a);

        //Mathf.Sqrt square root
        //Mathf.Pow (alap, kitevõ); tetszõleges hatványra emelés; a kitevõ is lehet float, nem csak az alap
        // a raised to the power of b

        pow = Mathf.Pow(a,b);
        // pl. 30^33 túl nagy, a float már infinity-t fog kiírni, nem tudja tárolni
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

    float AbsoluteValue(float a) //lokális változó
    {
        if (a > 0)
            return a;
        else
            return -a;
        // return a >= 0? a : -a;

    }

    //osztályon belül nem lehet ugyanaz a neve két változónak, fieldben szintén; viszont függvégnyek lehet ugyanaz a változó neve

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
