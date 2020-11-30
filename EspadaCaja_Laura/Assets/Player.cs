using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;

        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);

        transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);

    }
}
