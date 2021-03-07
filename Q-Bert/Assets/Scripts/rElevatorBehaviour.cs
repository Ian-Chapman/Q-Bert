using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rElevatorBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-2, 2, 0);
    }
}
