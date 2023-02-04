using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public double speed;
    public float rootSpeed;
    public float rootTimer;
    public GameObject land;
    public GameObject root;
    public Vector3 max;
    bool spawn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = (float)speed * Time.deltaTime;
        float rootStep = (float)rootSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, land.transform.position, step);

        if(transform.position == land.transform.position)
        {
            if(rootTimer > 0)
            {
                rootTimer -= Time.deltaTime;
            }
            if(rootTimer <= 0)
            {
                spawn = true;
            }

            if(spawn == true)
            {
                if (root.transform.localScale.y < max.y)
                {
                    root.transform.localScale = Vector3.Lerp(root.transform.localScale, max, rootSpeed * Time.deltaTime);
                }
            }
        }
    }
}
