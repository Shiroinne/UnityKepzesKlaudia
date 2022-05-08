using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed = 0;

    void Update()
    {
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        float xMovement = ToNumber(right, left);


        //bool jump = Input.GetKeyDown(KeyCode.Space);

        // if jump
        //  Debug.Log($"{jump}");

        //Debug.Log($"{right} {left} {jump}");



        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        float zMovement = ToNumber(up, down);

        Vector3 movement = new Vector3(xMovement, 0, zMovement);
        movement.Normalize();
        movement *= Time.deltaTime;
        movement *= speed;


        transform.position += movement;
        //ua transform.Translate(movement, Space.World);
        //Space.World nélkül localposition


        if (movement.magnitude != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            Quaternion currentRotation = transform.rotation;

            transform.rotation =
                Quaternion.RotateTowards
                (currentRotation,
                targetRotation,
                angularSpeed * Time.deltaTime);
        }
    }



    float ToNumber(bool positive, bool negative)
        {
        float positiveValue = positive ? 1 : 0;
        float negativeValue = negative ? -1 : 0;

        return positiveValue + negativeValue;
        }
}
