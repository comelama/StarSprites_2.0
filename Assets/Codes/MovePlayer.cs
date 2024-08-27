using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rdb;
    public float velocidade = 10;
    public SpriteRenderer fogo1;
    public SpriteRenderer fogo2;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -7, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()//FixedUpdate é chamado a cada frame, mas é chamado com um tempo fixo
    {
        /// <summary>
        /// funcao que movimenta o player
        /// <summary>
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.D)) //se aperta a tecla D
        {
            rdb.AddTorque(-velocidade); //adiciona torque para a direita
        }
        if (Input.GetKey(KeyCode.A))
        {
            rdb.AddTorque(velocidade);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rdb.AddRelativeForce(Vector2.up * velocidade);
            fogo1.enabled = true;
            fogo2.enabled = true;
        }
        else
        {
            fogo1.enabled = false;
            fogo2.enabled = false;
        }

    }
}









