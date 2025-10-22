using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Head prefab 
    public GameObject headPrefab;
    public GameObject pnMenuStart;
    public GameObject pnMenuGameOver;
    public SpawnFood spawnFood;
    public Text scoreGame;
    public Text scoreGameOver;


    private bool gamePlay;
    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        gamePlay = false;
        pnMenuStart.SetActive(true);
        pnMenuGameOver.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gamePlay == false)
        {
            StartGame();
        }

        scoreGame.text = "SCORE: "+score.ToString();
    }
    //inicia o jogo
    public void StartGame()
    {
        pnMenuStart.SetActive(false); //desativa o menu
        gamePlay = true; //inicia o jogo
        scoreGame.text = "SCORE: 0";
        score = 0;
        spawnFood.StartSpawnFood();  //inicia a criação da comida
        Instantiate(headPrefab, new Vector2(0f,0f), Quaternion.identity); //cria a cobra
    }

    //termina o jogo 
    public void GameOver()
    {
        pnMenuGameOver.SetActive(true);
        scoreGameOver.text = "SCORE: " + score.ToString();
        Invoke("RestartGame", 5);
    } 
    //reinicia a cena
    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void IncScore()
    {
        score += 10;
    }
}
