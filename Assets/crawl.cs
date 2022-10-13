using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawl : MonoBehaviour
{
    // Start is called before the first frame update
    private LineRenderer bolas;
    private Vector3 startpoint;
    public GameObject spread;
    private Vector3 dirpoint;
    private int spawned ;
    
    void Start()
    {
        bolas = GetComponent<LineRenderer>();
        startpoint = new Vector3(0, 0, 0);
        Debug.Log(startpoint + "b4");
        //  tempendpoint = startpoint 
         dirpoint = startpoint;
        if (gameObject.name == "North")
        {
            dirpoint.y += 1;
        }
        if (gameObject.name =="South")
        {
            dirpoint.y -= 1;
        }
        if (gameObject.name == "East")
        {
            dirpoint.x += 1;
        }
        if (gameObject.name == "West")
        {
            dirpoint.x -=1;
        }
        Debug.Log(dirpoint + "4tr");
        bolas.positionCount=2;

        bolas.SetPosition(0,startpoint);
        bolas.SetPosition(1, dirpoint);
        //  Instantiate(bruh,startpoint , Quaternion.identity);
        spawned = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
        if(spawned == 0)
        {
             //  Instantiate(spread,startpoint , Quaternion.identity);
            spawned++;
        }
        

        //Debug.Log("linerenderpoint count"+ gameObject.positionCount);
    }

  
    
}
