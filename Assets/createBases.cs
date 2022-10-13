using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createNodes : MonoBehaviour
{
    // I just realized that makenest does the same thing. my bad.
    public int numBases = 5;
    public GameObject basePrefab;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = .5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numBases; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            GameObject newBase = Instantiate(basePrefab, spawnPosition, Quaternion.identity); // create base
            if (i != 0) // set other bases to inactive except for first one
            {
                newBase.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
