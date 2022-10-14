using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform target; // player position
    public float speed;
    public float inRange;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(target.position, transform.position); 
        if (dist <= inRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        } else {
            Vector3 tmp = this.transform.position;
            tmp.y -= speed;
            transform.position = tmp;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
