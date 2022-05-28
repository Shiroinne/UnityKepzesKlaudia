using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] AnimationCurve speedOverDistance; 

    void Update()
    {
        if (target == null)
            return;

        Vector3 targetPos = target.position;
        Vector3 enemyPos = transform.position;

        Vector3 movement = targetPos - enemyPos;

        float distance = movement.magnitude;
        float speed = speedOverDistance.Evaluate(distance);

        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;

        transform.position += movement;

        if (movement.magnitude != 0)
            transform.rotation = Quaternion.LookRotation(movement);
    }
}
