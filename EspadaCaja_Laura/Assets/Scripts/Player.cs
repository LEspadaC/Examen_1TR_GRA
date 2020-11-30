using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;

    public Text guitext;

    int number = 0;

    float secondsCounter = 0;
    float secondsToCount = 1;

    [SerializeField] Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();

        secondsCounter += Time.deltaTime;
        if (secondsCounter >= secondsToCount)
        {
            secondsCounter = 0;
            number++;
        }
        guitext.text = number.ToString();

        TimeText.text = "Tiempo transcurrido: " + guitext.text;
    }

    void movePlayer()
    {
        float posX = transform.position.x;
        float posZ = transform.position.z;

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
