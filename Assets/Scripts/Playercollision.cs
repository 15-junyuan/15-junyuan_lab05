using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playercollision : MonoBehaviour
{
    public Text Scoretxt;
    public Text Timetxt;

    //Score
    int Score;

    //Time
    public float time;
    public bool timerisrunning = false;


    // Start is called before the first frame update
    void Start()
    {
        //scoretxt//
        Scoretxt.text = "Score: " + Score;

        //timer
        timerisrunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerisrunning)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                DisplayTime(time);
            }
            else
            {
                Debug.Log("end");
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        Timetxt.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }

    //collision
   /* private void OnCollisionEnter(Collision collision)
    {
        //collision with coin
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("Touch");
            Score =+ Score + 10;
            Scoretxt.text = "Score: " + Score;
            Destroy(collision.gameObject);
        }

        //collision with water
        if (collision.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLose");
        }
    }*/
   
}
