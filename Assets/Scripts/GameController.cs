using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public int laps;
    public Text winText;
    bool endGame = false;

    public Text countdown;
    public float timeToStart = 3f;
    public bool started = false;

 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeToStart > 0)
        {
            timeToStart-= Time.deltaTime;
            countdown.text = Mathf.RoundToInt(timeToStart).ToString();
        }
        else
        {
            started = true;
            countdown.gameObject.SetActive(false);
        }

        if(endGame && Input.anyKeyDown)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    public void EndGame(int num)
    {
        endGame = true;
        winText.gameObject.SetActive(true);
        winText.text = "Player " + num + " wins! Press Any Key To Restart!";
    }
}
