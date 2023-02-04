using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Core : MonoBehaviour
{

    public GameObject gameOverPanel;

    public ParticleSystem overheat;
    public int counter = 0;
    public float timer = 3;
    public bool end = false;
    int spawnNumber;
    public GameObject ProSeed;
    public GameObject point0;
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;
    public GameObject point4;
    public GameObject point5;
    public GameObject point6;
    public GameObject point7;


    bool spawned = false;
    float spawnTimer = 7;

    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem overheat = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(spawned == false)
        {
            spawnNumber = Random.Range(1, 9);
            if (spawnNumber == 1)
            {
                Instantiate(ProSeed, point0.transform.position, point0.transform.localRotation);
                spawned = true;
            }
            if (spawnNumber == 2)
            {
                Instantiate(ProSeed, point1.transform.position, point1.transform.localRotation);
                spawned = true;
            }
            if (spawnNumber == 3)
            {
                Instantiate(ProSeed, point2.transform.position, point2.transform.localRotation);
                spawned = true;
            }
            if (spawnNumber == 4)
            {
                Instantiate(ProSeed, point3.transform.position, point3.transform.localRotation);
                spawned = true;
            }
            if (spawnNumber == 5)
            {
                Instantiate(ProSeed, point4.transform.position, point4.transform.localRotation);
                spawned = true;
            }

            if (spawnNumber == 6)
            {
                Instantiate(ProSeed, point5.transform.position, point5.transform.localRotation);
                spawned = true;
            }
            if (spawnNumber == 7)
            {
                Instantiate(ProSeed, point6.transform.position, point6.transform.localRotation);
                spawned = true;
            }
            if (spawnNumber == 8)
            {
                Instantiate(ProSeed, point7.transform.position, point7.transform.localRotation);
                spawned = true;
            }


        }
        

        if(spawned == true)
        {
            if (spawnTimer > 0)
            {
                spawnTimer -= Time.deltaTime;
            }
            if (spawnTimer <= 0)
            {
                spawnTimer = 7;
                spawned = false;
            }
        }




        if (counter >= 2)
        {
            overheat.Play();
        }
        if(counter < 2)
        {
            overheat.Stop();
        }

        if(counter >= 3)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            if (timer <= 0)
            {
                end = true;
            }
        }
        if(counter < 3)
        {
            timer = 3;
        }

        if(end == true)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            counter += 1;
        }
    }
}
