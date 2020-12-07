using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamcontroller : MonoBehaviour
{
    public static gamcontroller gami;
    public GameObject gameOvertext;
    public bool gameOver;
    public float speed = -1.5f;
    private int score;
    public Text scoreText;
    public ControllTouch boton;
    // Start is called before the first frame update

    private void Awake()
    {
        gamcontroller.gami = this;
    }

    public void BirdScore() 
    {
        if (gameOver == true)
        {
            return;
        }
        else
        {
            score++;
            SoundSystem.sonidito.PlayCoin();
            scoreText.text = "Score: " + score;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetKeyDown(KeyCode.A))
        {
            gameOver = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //  SceneManager.LoadScene(0);
        } else if (gameOver == true && boton.pulsar == true) 
        {
            gameOver = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void birdDie() 
    {
        gameOvertext.SetActive(true);
        gameOver = true;
    }

}
