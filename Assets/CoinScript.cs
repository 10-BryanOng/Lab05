using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    private int Score;
    public int TotalCoins;
    public float TimeLeft;
    public int TimeRemaining;
    private float Timer;

    public GameObject Coinfx;

    public Text ScoreText;
    public Text TimeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeLeft -= Time.deltaTime;
        TimeText.GetComponent<Text>().text = "Time: " + TimeLeft;

        if(Score >= 60)
        {
            SceneManager.LoadScene("GameWin");
        }

        if(TimeLeft <= 0f)
        {
            SceneManager.LoadScene("GameLose");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Instantiate(Coinfx, other.transform.position, Quaternion.identity);
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
