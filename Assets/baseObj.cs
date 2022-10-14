using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseObj : MonoBehaviour
{
    Rigidbody2D rb2d;
    public int lengthOfLineRenderer = 20;
    public int interpolationFramesCount = 45; // Number of frames to completely interpolate between the 2 positions
    public GameObject enemPrefab;
    public Transform playerPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        float startIn = 1;
        float every = 5;
        InvokeRepeating("spawn", startIn, every);
    }

    void FixedUpdate()
    {
        Vector2[] directions = { Vector2.up, Vector2.down, Vector2.left, Vector2.right };
        foreach (Vector2 i in directions)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, i);
            if (hit.collider != null && hit.transform.gameObject.name == "base")
            {
                /*float dist = Mathf.Abs(hit.point.y - transform.position.y);
                LineRenderer lineRenderer = GetComponent<LineRenderer>();*/
                Vector3 target = hit.transform.position;
                //lineRenderer.SetPosition(0, tar);
                Debug.DrawLine(this.transform.position, target, Color.blue);
                hit.transform.gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void spawn()
    {
        GameObject enemy = Instantiate(enemPrefab, this.gameObject.transform.position, Quaternion.identity);
        enemy.GetComponent<enemy>().target = playerPosition;
    }

   
}
