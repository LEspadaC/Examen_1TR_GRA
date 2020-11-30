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

        print(posZ);

        float desplZ = Input.GetAxis("Vertical");
        float desplX = Input.GetAxis("Horizontal");

        if (posX > -9.5 && posX < 9.5 || posX < -9.5 && desplX > 0 || posX > 9.5 && desplX < 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
        }

        if (posZ > -9.5 && posZ < 9.5 || posZ < -9.5 && desplZ > 0 || posZ > 9.5 && desplZ < 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
        }

    }
}
