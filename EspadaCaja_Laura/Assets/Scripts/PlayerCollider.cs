using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private CreateObstacles obstacles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Obstacle(Clone)")
        {
            Destroy(other.gameObject);
            obstacles.counter--;
        }
    }
}
