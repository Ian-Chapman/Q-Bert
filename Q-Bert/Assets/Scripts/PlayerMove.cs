using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public bool isInAir = false;

    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
       // isInAir = false;

        if (Input.GetKeyDown("a")) //jump down left
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);

            //if (isInAir == true)
            //{
            //    GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //}
        }

        if (Input.GetKeyDown("w")) //jump up right
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }

        if (Input.GetKeyDown("d")) //jump down right
        { 
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown("e")) //jump up left
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }

    }
}
