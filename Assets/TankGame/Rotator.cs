using System;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    void Update()
    {
        transform.Rotate(new Vector3(0, angularSpeed* Time.deltaTime, 0), Space.World);
    }
}
