using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour
{
    public GameObject bulletprefab;
    public Transform firePoint;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }
    void Fire()
    {
        //instanciar o tiro na posicao do player e com a rotacao padrao
        GameObject bullet = Instantiate(bulletprefab, firePoint.position, firePoint.rotation);
        // adicionar força para cima no tiro para ele subir
        bullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * 10, ForceMode2D.Impulse);
    }

}
