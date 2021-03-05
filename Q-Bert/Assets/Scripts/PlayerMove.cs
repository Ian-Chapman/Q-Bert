using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool isInAir = false; //So player cannot spam movement buttons. May also assist with character animations later


    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        if (isInAir == false)
        {

            if (Input.GetKeyDown("a")) //jump down left
            {
                isInAir = true;
                GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
            }

            if (Input.GetKeyDown("w")) //jump up right
            {
                isInAir = true;
                GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
            }

            if (Input.GetKeyDown("d")) //jump down right
            {
                isInAir = true;
                GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
            }

            if (Input.GetKeyDown("e")) //jump up left
            {
                isInAir = true;
                GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
            }
        }

    }

    private void OnTriggerEnter(Collider other) //For collisions with the ground
    {
        if (other.tag == "Ground")
        {
            GetComponent<Transform>().position = new Vector3(0, 1, 0); //Bring Qbert back to the top and drop from 1 on y axis
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0); //Only gravity will affect velocity

            maingame.remainingLives -= 1;
            Debug.Log(maingame.remainingLives);
        }

        if (other.tag == "Elevator_Stop")
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }

    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "tile")
        {
            StartCoroutine(delayPlayerMove());
        }

        if (other.gameObject.tag == "Red_Ball_Bounce") // do this for coily ball too.
        {
            maingame.death = true;
            maingame.remainingLives -= 1;
            GetComponent<Transform>().position = new Vector3(0, 1, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            StartCoroutine(delayDeath());
        }
    }

    IEnumerator delayPlayerMove()
    {
        yield return new WaitForSeconds(.01f); //Removes all chances of player wobble on landing due to small collision box
        isInAir = false;
    }

    IEnumerator delayDeath()
    {
        yield return new WaitForSeconds(.1f);
        maingame.death = false;
    }
}
