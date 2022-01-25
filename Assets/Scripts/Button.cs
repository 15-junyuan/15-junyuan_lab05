using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    //restart button
    public void RestartBtn()
    {
        SceneManager.LoadScene("GameScene");
    }
}
