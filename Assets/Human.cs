using UnityEngine;

public class Human : MonoBehaviour
{
    /*[SerializeField] int i1;
    [SerializeField] int i2;
    [Space]
    [SerializeField] string s1;
    [SerializeField] string s2;
    [Space]
    [SerializeField] bool isEqual;
    [SerializeField] bool isGreater;
    [SerializeField] bool isGreaterOrEqual;
    [SerializeField] bool isLower;
    [SerializeField] bool isLowerOrEqual;
    [Space]
    [SerializeField] bool areStringsEqual;
      void OnValidate()
    {
        bool a = true;
        bool b = false;

        isEqual = i1 == i2;
        isGreater = i1 < i2;
        isLower = i1 > i2;

        isGreaterOrEqual = isGreater || isEqual;
        isLowerOrEqual = !isGreater;

        areStringsEqual = s1 == s2;

        bool x = (a || b) && a;
        bool y = !(a && (b || true));

    }
    */

    [SerializeField] string firstName = "NO NAME";
    [SerializeField] string familyName = "NO NAME";
    [SerializeField, Min(1900)] int born = 1950;
    [SerializeField, Range(50, 300)] float height = 160;
    [SerializeField] bool isAlive = true;

    [Space]
    [SerializeField] bool blabla;
    [SerializeField] bool krixkrax;

    //BLABLA
    //élnie kell
    //magasabb 160 cm-nél, de kisebb 200-nál
    //2000 vagy az után születettek

    //KRIXKRAX
    //kisebb 180 cm-nél, vagy nagyobb 210 cm-nél
    //instant felvesznek, HA a keresztneved és a vezetékneved megegyezik


     void OnValidate()
    {
        // blabla = isAlive && (height > 160 && height < 200) && born >= 2000;

        bool heightIsRight = height > 160 && height < 200;
        bool ageIsRight = born >= 2000;

        blabla = isAlive && heightIsRight && ageIsRight;

        heightIsRight = height < 180 || height > 210;
        bool isNameEqual = firstName == familyName;

        krixkrax = heightIsRight || isNameEqual;


        
    }
}
