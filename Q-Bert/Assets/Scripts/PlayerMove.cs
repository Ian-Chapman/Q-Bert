using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a")) //jump down left
        {
            //transform.eulerAngles = new Vector3(-90, 0, 180);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 4, -1);
        }

        if (Input.GetKeyDown("w")) //jump up right
        {
            //transform.eulerAngles = new Vector3(-90, 0, 0);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 6, 1);
        }

        if (Input.GetKeyDown("d")) //jump down right
        {
            //transform.eulerAngles = new Vector3(-90, 0, 90);
            GetComponent<Rigidbody>().velocity = new Vector3(1, 4, 0);
        }

        if (Input.GetKeyDown("e")) //jump up left
        {
            //transform.eulerAngles = new Vector3(-90, 0, -90);
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 6, 0);
        }

    }
}
