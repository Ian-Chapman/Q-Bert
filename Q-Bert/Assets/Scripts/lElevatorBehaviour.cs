using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lElevatorBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 2, 2);
    }
}
