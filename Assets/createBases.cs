using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBases : MonoBehaviour
{
    // I just realized that makenest does the same thing. my bad.
    public int numBases = 9;
    public GameObject basePrefab;
    public float levelWidth = 3f;
    public float minY = .5f;
    public float maxY = .5f;

    public Transform playerPlace;
    // Start is called before the first frame update
    void Start()
    {
        List<int> rand = new List<int>();
        for (int i = 0; i < numBases / 2 - 1; i++)
        {
            rand.Add(Random.Range(0, numBases));
        }
        Vector3 spawnPosition = new Vector3(0.5f,0.5f, 0f);
        int dim = (int)Mathf.Sqrt(numBases);
        for (int i = 0; i < dim; i++)
        {
            spawnPosition.x = 0.5f;
            for (int j = 0; j < dim; j++)
            {
                //spawnPosition.y += 0.5f * i;
                //spawnPosition.x += 0.5f * i;
                GameObject newBase = Instantiate(basePrefab, spawnPosition, Quaternion.identity); // create base
                newBase.GetComponent<baseObj>().playerPosition = playerPlace;

                if (!rand.Contains(i * j + j)) // set other bases to inactive except for first one
                {
                    newBase.SetActive(false);
                }
                spawnPosition.x += 1;
            }
            spawnPosition.y += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
