using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            Score += 10;
            print("Score");
        }

        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
