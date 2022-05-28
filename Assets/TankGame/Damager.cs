using System;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] int damage;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{name} <-> {other.name}");

        Damagable damage = other.GetComponent<Damagable>();

        if (damage != null)
        {
            damage.DoDamage(this.damage);
        }
    }
}
