using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makenest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Nest;

    private void Awake()
    {
        for (int x = 0; x < 2; x++) {
            Vector3 randnewNest = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);
            Instantiate(Nest, randnewNest, Quaternion.identity);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
