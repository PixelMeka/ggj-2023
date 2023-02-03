using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HizOlcme : MonoBehaviour
{

    private Vector3 previousPosition;
    public float curSpeed;
    public ParticleSystem dirt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 curMove = transform.position - previousPosition;
     curSpeed = curMove.magnitude / Time.deltaTime;
     previousPosition = transform.position;

     if(curSpeed == 0){
        dirt.Stop();
     }
     
    if(curSpeed != 0){
        dirt.Play();
    }
    }
}
