using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker : MonoBehaviour
{
    [SerializeField] float blockingTime;
    private void OnTriggerEnter(Collider other)
    {
        Blockable b = other.GetComponent<Blockable>();
        if (b != null)
            b.Block(blockingTime);
    }

}

