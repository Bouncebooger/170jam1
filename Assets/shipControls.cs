using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipControls : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5.0f;
    public float rotation = 0.30f;
    public GameObject player_Bullet;
    public Transform attack_Point;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        shoot();
        checkAngle();
        
    }

    void movePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;

            transform.position = temp;
        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;

            transform.position = temp;
        }

        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;

            transform.position = temp;
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;

            transform.position = temp;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            Quaternion temp = transform.rotation;
            temp.z = rotation;
            transform.rotation = temp;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            Quaternion temp = transform.rotation;
            temp.z = -rotation;
            transform.rotation = temp;
        }
        else
        {
            Quaternion temp = transform.rotation;
            temp.z = 0;
            transform.rotation = temp;
        }
    }

    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(player_Bullet, attack_Point.position, Quaternion.identity);
        }
    }

    void checkAngle()
    {

    }
}
