using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBases : MonoBehaviour
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
        List<int> rand = new List<int>();
        for (int i = 0; i < numBases / 2 - 1; i++)
        {
            rand.Add(Random.Range(0, numBases));
        }
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numBases; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            GameObject newBase = Instantiate(basePrefab, spawnPosition, Quaternion.identity); // create base
            if (!rand.Contains(i)) // set other bases to inactive except for first one
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
