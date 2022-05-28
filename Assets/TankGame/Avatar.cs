using UnityEngine;

public class Avatar : MonoBehaviour
{
    [SerializeField] float speed =1;
   // [SerializeField] float maxSpeed = 5;
    [SerializeField] float angularSpeed = 360;
    Damagable damagable;
    [SerializeField] Space movementSpace = Space.World;
    [SerializeField] GameObject projectilePrototype;

    //[SerializeField] int health = 3;

    /* public void DoDamage(int damage)
     {
         health -= damage;
         if (health <= 0)
             Debug.Log("I'm dead!");
     }*/

    void Start()
    {
        damagable = GetComponent<Damagable>();
    }
    void Update()
    {
        if (damagable.health > 0)
        {
            Move();
            TryShoot();
        }
    }

    void TryShoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(projectilePrototype);
            go.SetActive(true);
            Projectile p = go.GetComponent<Projectile>();

            Vector3 forward = transform.forward;
            go.transform.position = projectilePrototype.transform.position;
            p.Shoot(forward);
        }
    }

    public void Move()
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

        if (movementSpace == Space.Self)
        {
            movement = transform.TransformVector(movement);
        }

        movement.y = 0;
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

    public void RestartAvatar()
    {
        transform.position = Vector3.zero;
    }
}
