using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{
    public float bulletSpeed = 5f;
    public float activeTimer = 3f;


    // Update is called once per frame
    //private void Start()
    //{
    //    Invoke("DeactivateGameObject", activeTimer);
    //}
    void Update()
    {
        //if called
        Vector3 temp = transform.position;
        temp.y += bulletSpeed * Time.deltaTime;
        transform.position = temp;

        Destroy(gameObject, 3);

        //if hit enemy or edge of screen, disappear 
        //if hit mirror, bounce
    }

    //void DeactivateGameObject()
    //{
    //    Destroy(this);
    //}
}

