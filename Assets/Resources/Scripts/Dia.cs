using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dia : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       
        if (transform.position.x < -25)
        {
            Destroy(gameObject);
        }
        else
        {

            
            transform.Translate(-SkyscraperSpawner.speed * Time.deltaTime, 0, 0, Space.World);
        }

        
        transform.Rotate(0, 5f, 0, Space.World);
    }

    void OnTriggerEnter(Collider other)
    {

        // trigger coin pickup function if a helicopter collides with this
        other.transform.parent.GetComponent<HeliController>().PickupDia();
        Destroy(gameObject);
    }
}