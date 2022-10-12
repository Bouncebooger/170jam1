using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeweb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wire;
   // private GameObject[] LineRenderer; 
    private int webcount;
    private Vector3 addy;
    private LineRenderer webster;

    void Awake()
    {


        addy = transform.position;
        Debug.Log("hello addy is " + addy);
    }
    void Start()
    {
        webster = GetComponent<LineRenderer>();

        webcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (webcount == 0)
        {
         
            Vector3 point2 = new Vector3(-2f, 5, 10);
            Vector3 baddy = addy;
            baddy.x = addy.x+ (Random.Range(1,2));
            baddy.y = addy.y+0.5f;
            baddy.z = addy.z+0.5f;

            webster.positionCount = 2;
            webster.SetPosition(0,baddy);
            webster.SetPosition(1,point2);
            // Instantiate(wire, baddy, Quaternion.identity);
            webcount++;
            Debug.Log("baddy is " + baddy);
        }
    }
}
