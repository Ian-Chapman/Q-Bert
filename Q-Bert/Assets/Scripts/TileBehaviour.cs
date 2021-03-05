using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviour : MonoBehaviour
{
    public Material Purple;
    public int colourCode = 1; //Prevent T1 from changing color at game start

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) //for collision with any other game object
    {
        if (other.gameObject.tag == "Qbert_Idle_Left_Down-1") // OR other Qbert animations to be used later
        {
            colourCode -= 1;
            if (colourCode == 0) // change a tile to have color code -1
            {
                GetComponent<Renderer>().material = Purple;
                maingame.remainingTiles -= 1;
            }
        }
    }
}
