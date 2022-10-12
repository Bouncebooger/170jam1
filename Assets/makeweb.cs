using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeweb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wire;
    private int webcount;
    private Vector3 addy;
     void Awake()
    {
        addy = transform.position;
        Debug.Log("hello addy is " + addy);
    }
    void Start()
    {
         
        webcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (webcount == 0)
        {
            Vector3 baddy = addy;
            baddy.x = addy.x+0.5f;
            baddy.y = addy.y+0.5f;
            baddy.z = addy.z+0.5f;
            
            Instantiate(wire, baddy, Quaternion.identity);
            webcount++;
            Debug.Log("baddy is " + baddy);
        }
    }
}
