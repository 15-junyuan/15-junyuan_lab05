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
    private float Score;
    public float totalcoins;

    //Time
    public float timeleft;
    public int timeremaining;

    private float Timevalue;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        timeremaining = Mathf.FloorToInt(timeleft % 60);
        Timetxt.text = "Timer : " + timeremaining.ToString();

        if (Score == totalcoins)
        {
            if (timeleft >= Timevalue)
            {
                SceneManager.LoadScene("GameWin");
            }
        }
        else if(timeleft <= 0)
        {
           SceneManager.LoadScene("GameLose");
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
       //collision with coins
        if(other.gameObject.tag == "Coins")
        {
            Score = +Score + 10;
            Scoretxt.text = "Score: " + Score;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLose");
        }

    }
}
