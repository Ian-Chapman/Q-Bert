using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (maingame.death == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        //Create the randomness needed to have the ball fall between a choice of 2 tiles
        if (Random.Range(0, 2) == 0)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Qbert_Idle_Left_Down-1") //OR other Qbert assets
        {
            // Freeze all enemies
            Destroy(gameObject);
        }
    }
}
