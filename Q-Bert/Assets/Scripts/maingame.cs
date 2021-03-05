using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maingame : MonoBehaviour
{
    public static int remainingTiles = 28;
    public static int remainingLives = 3;
    public Transform redBallBounceObj;

    void Start()
    {
        StartCoroutine(spawnRedBallBounce());
    }

    void Update()
    {
        if (remainingTiles == 0)
        {
            Debug.Log("Win");
            StartCoroutine(newLevel()); //check for all tiles changed - reset the level
        }
    }

        IEnumerator newLevel() //reload the level - may add other menus to load here later or remove for end game animation
        {
            yield return new WaitForSeconds(4); // add short delay before map reloads on itself
            remainingTiles = 28; //reset number of tiles to be added to the game
            SceneManager.LoadScene("myMap");
        }

       
        IEnumerator spawnRedBallBounce()
        {
            yield return new WaitForSeconds(3); //Spawn 3 seconds after game begins
            Instantiate(redBallBounceObj, new Vector3(0, 2, 0), redBallBounceObj.rotation); //Ball will spawn above top tile

            StartCoroutine(spawnRedBallBounce()); //Recursive
        }

    
}
