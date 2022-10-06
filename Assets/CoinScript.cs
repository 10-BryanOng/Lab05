using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    private int Score;
    private float Timer = 20f;

    public Text ScoreText;
    public Text TimeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        TimeText.GetComponent<Text>().text = "Time: " + Timer * Mathf.Round(Timer * 10) / 10;

        if(Score >= 60)
        {
            SceneManager.LoadScene("GameWin");
        }

        if(Timer <= 0f)
        {
            SceneManager.LoadScene("GameLose");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            Score += 10;
            ScoreText.GetComponent<Text>().text = "Score:" + Score;
        }

        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
