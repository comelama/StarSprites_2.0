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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        particleSystem.Emit(1);
    }
}

