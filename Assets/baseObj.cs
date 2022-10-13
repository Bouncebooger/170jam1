using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseObj : MonoBehaviour
{
    Rigidbody2D rb2d;
    public int lengthOfLineRenderer = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up);
        if (hit.collider != null)
        {
            float dist = Mathf.Abs(hit.point.y - transform.position.y);
            LineRenderer lineRenderer = GetComponent<LineRenderer>();
            Vector3 tar = hit.transform.position;
            lineRenderer.SetPosition(0, tar);
            //var t = Time.time;
            /*for (int i = 0; i < lengthOfLineRenderer; i++)
            {
                lineRenderer.SetPosition(i, new Vector3(i * 0.5f, Mathf.Sin(i + t), 0.0f));
            }*/
            hit.transform.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
