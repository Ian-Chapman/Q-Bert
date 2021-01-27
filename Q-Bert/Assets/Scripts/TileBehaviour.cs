using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviour : MonoBehaviour
{
    public Material Green;
    public int colourCode = 1; //Prevent T1 from changing colour at game start

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) //for collision with any other game object
    {

        colourCode -= 1;
        if (colourCode == 0)
        {
            GetComponent<Renderer>().material = Green;
       //GameFlow
        }

    }
}
