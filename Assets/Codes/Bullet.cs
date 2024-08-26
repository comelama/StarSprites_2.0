using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    
    [SerializeField] private float bulletLifeTime = 1.5f;

    private void Awake()
    {
        Destroy(gameObject, bulletLifeTime);
    }

    void Start()
    {
        Destroy(gameObject, 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);
        }
        Destroy(gameObject);
    }
}