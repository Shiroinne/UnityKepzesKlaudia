using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockable : MonoBehaviour
{
    [SerializeField] MonoBehaviour blockedScript;
    [SerializeField] Collider blockedCollider;

    float unblockTime;
    bool isBlocked;
    public void Block(float blockingTime)
    {
        Debug.Log("eadghdthdj");
        SetEnable(false);
        unblockTime = Time.time + blockingTime;
        isBlocked = true;

    }

    void SetEnable(bool enable)
    {
        blockedScript.enabled = enable;
        blockedCollider.enabled = enable;
    }

    void Update()
    {
        if (isBlocked && Time.time >= unblockTime)
        {
            SetEnable(true);
            isBlocked = false;
        }   
    }
}
