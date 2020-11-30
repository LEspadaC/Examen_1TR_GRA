using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacles : MonoBehaviour
{
    [SerializeField] GameObject MyObstacle;
    [SerializeField] Transform RefPos; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ObstacleCorrutine");
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void createObstacle()
    {     
        float posRandom1 = Random.Range(-9.5f, 9.5f);
        float posRandom2 = Random.Range(-9.5f, 9.5f);

        Vector3 DestPos = new Vector3(posRandom1, 0, posRandom2);
        Vector3 NewPos = RefPos.position + DestPos;

        Instantiate(MyObstacle, NewPos, Quaternion.identity);
    }

    IEnumerator ObstacleCorrutine()
    {
        int n;
        int counter = 0;

        for (n = 0; ; n++)
        {   
            if(counter <= 5)
            {
                createObstacle();
                counter++;
                yield return new WaitForSeconds(2);
            }
            else if(counter > 5 && counter <= 10)
            {
                createObstacle();
                counter++;
                yield return new WaitForSeconds(1);
            }
            else
            {
                createObstacle();
                counter++;
                yield return new WaitForSeconds(0.5f);
            }

        }
    }
}
