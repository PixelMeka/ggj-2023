using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MakineHareketi : MonoBehaviour
{
    private UnityEngine.AI.NavMeshAgent degisken;
    public Camera cam;
    public ParticleSystem dirtHit;
    AudioSource audioSource;
    public GameObject machineModel;
    Vector3 sliceLoc;

    // Start is called before the first frame update
    void Start()
    {
        degisken = GetComponent<UnityEngine.AI.NavMeshAgent>();

        audioSource = machineModel.GetComponent<AudioSource>();
        ParticleSystem dirtHit = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            
            Debug.DrawRay(ray.origin, ray.direction * 1000f);

            if(Physics.Raycast(ray, out RaycastHit rayHit) && NavMesh.SamplePosition(rayHit.point, out NavMeshHit navMeshHit, 1.0f, UnityEngine.AI.NavMesh.AllAreas))
            {
                degisken.SetDestination(navMeshHit.position);
            }
        }
        
        // if(Input.GetMouseButtonDown(0))
        // {
        //     var ray = cam.ScreenPointToRay(Input.mousePosition);
            
        //     if(Physics.Raycast(ray, out RaycastHit dokunmak))
        //     {
        //         degisken.SetDestination(dokunmak.point);
        //     }
        // }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            dirtHit.Play();
            audioSource.Play();
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
      //  if(collision.transform.gameObject.name == "Enemy")
     //   {
      //      print("asd");
     //       sliceLoc = collision.contacts[0].point;
     //       Instantiate(sliceEffect, sliceLoc, Quaternion.identity);
            
     //   }
        
    //}
}
