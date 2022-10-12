using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeweb : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wire;
    private bool[] webconnect = new bool[4] ;
    private int webmade = 0;
    private int baseconnect = 0;
    private int webdistmax = 4;
    private  LineRenderer[] amogus = new LineRenderer[4]; 
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
        webspawn();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void webspawn()
    {
        
        if (baseconnect < webmade )
        {
            Debug.Log("Stop Posting about SPIDERS(1982)2");
            return;
        }
        else 
        {
            if (webmade >= 4)
            {
                Debug.Log("alarm!");
                return;
            }
            int weblim = Random.Range(1, (4 - webmade));
            for(  int z = 0; z < weblim; z++)
            {
                LineRenderer newweb = GetComponent<LineRenderer>();
                amogus[webmade] = newweb;
                webmade++;
                Debug.Log("Stop Posting about SPIDERS(1982)"+weblim);
            } 
            //make wires numbering in range (1-(4-baseconnect))
        }
    }
    void webstep(LineRenderer orbweb)
    {
        if(orbweb.positionCount < webdistmax)
        {
            orbweb.positionCount++;
      //      orbweb.SetPosition(orbweb.positionCount-1,)
           //move towards base with wobble decreasing on every next point.
        }
    }

}
