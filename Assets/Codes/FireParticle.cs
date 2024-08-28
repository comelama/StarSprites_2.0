using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FireParticle : MonoBehaviour
{
    public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        
            Fire();
        
    }
    void Fire()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            particleSystem.Play();
        }
        else
        {
            particleSystem.Stop();
        }
    }
}

