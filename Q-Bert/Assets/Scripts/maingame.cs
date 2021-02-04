using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maingame : MonoBehaviour
{
    public static int remainingTiles = 28;
    public Transform redBall;
    void Start()
    {
        //StartCoroutine(spawnRedBall());   
    }

    void Update()
    {
        if (remainingTiles == 0)
        {
            Debug.Log("Win");
            StartCoroutine(newLevel());
        }

        IEnumerator newLevel() //reload the level - may add other menus to load here later or remove for end game animation
        {
            yield return new WaitForSeconds(4); // add short delay before map reloads on itself
            remainingTiles = 28; //reset number of tiles to be added to the game
            SceneManager.LoadScene("myMap");
        }

        //IEnumerator spawnRedBall()
        //{
        //    yield return new WaitForSeconds(3);
        //    Instantiate(redBall, new Vector3(0, 2, 0), redBall.rotation);
        //}
    }
}
