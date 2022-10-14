using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{
    public float bulletSpeed = 5f;
    public float activeTimer = 3f;
    public Vector2 m_dir;
    private Rigidbody2D rb;


    private void Start()
    {
        m_dir = new Vector2(0, 1);
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //if called
        Vector3 temp = transform.position;
        //temp.y += m_dir.y * bulletSpeed * Time.deltaTime;

        rb.velocity = m_dir * bulletSpeed;
        transform.position = temp;

        Destroy(gameObject, 3);

        //if hit enemy or edge of screen, disappear 
        //if hit mirror, bounce
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mirror"))
        {
            Vector2 _mirrorNormal = collision.contacts[0].normal;
            m_dir = Vector2.Reflect(rb.velocity, _mirrorNormal).normalized;
            print(m_dir);

            m_dir.y = -m_dir.y;

            rb.velocity = m_dir * bulletSpeed;
        }
    }
}

