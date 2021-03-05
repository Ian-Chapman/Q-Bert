using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class maingame : MonoBehaviour
{
    public static int remainingTiles = 28;
    public static int remainingLives = 3;
    public static bool death = false; //lost a life
    public static int score = 0;
    public Text UIScore;

    public Transform redBallBounceObj;
    public Transform greenBallBounceObj;

    void Start()
    {
        StartCoroutine(spawnRedBallBounce());
        StartCoroutine(spawnGreenBallBounce());
    }

    void Update()
    {
        if (remainingTiles == 0)
        {
            Debug.Log("Win");
            StartCoroutine(newLevel()); //check for all tiles changed - reset the level
        }

        if (remainingLives < 1)
        {
            SceneManager.LoadScene("Game Over");
        }

        UIScore.text = score.ToString(); //display a score on the UI
        //convert ToString for int to string
    }

        IEnumerator newLevel() //reload the level - may add other menus to load here later or remove for end game animation
        {
            yield return new WaitForSeconds(4); // add short delay before map reloads on itself
            remainingTiles = 28; //reset number of tiles to be added to the game
            SceneManager.LoadScene("myMap");
        }

       
        IEnumerator spawnRedBallBounce()
        {
            yield return new WaitForSeconds(5); //Spawn 5 seconds after game begins // make longer for real gameplay
            Instantiate(redBallBounceObj, new Vector3(0, 2.5f, 0), redBallBounceObj.rotation); //Ball will spawn above top tile

            StartCoroutine(spawnRedBallBounce()); //Recursive
        }

        IEnumerator spawnGreenBallBounce()
        {
        yield return new WaitForSeconds(18); 
        Instantiate(greenBallBounceObj, new Vector3(0, 2, 0), greenBallBounceObj.rotation);

        StartCoroutine(spawnGreenBallBounce()); //Recursive
        }


}
