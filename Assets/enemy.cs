using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    //public float inRange;
    private float horizontalSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //target = GameObject.FindWithTag("Player").transform;
        horizontalSpeed = Random.Range(-0.01f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        //float dist = Vector3.Distance(target.position, transform.position);
        /*if (dist <= inRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        } else {
            Vector3 tmp = this.transform.position;
            tmp.y -= speed;
            transform.position = tmp;
        }*/
        Vector3 tmp = this.transform.position;
        tmp.y -= speed;
        tmp.x += horizontalSpeed;
        transform.position = tmp;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
