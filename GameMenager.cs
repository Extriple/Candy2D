using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{

    public static GameMenager instance;
    int score = 0;
    //Dodawanie zycia
    int live = 3;
    bool gameover = false;
    //Unity Engine UI
    public Text scoreText;
    //Pkt życia
    public GameObject liveHolder;
    public GameObject GameOverPanel;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {

    }

    void Update()
    {

    }
    //Funckja odpowiedzialna za zapisywanie zdobytych pkt - równieź wyświetla na ekranie
    public void IncrementalScore()
    {
        if (!gameover)
        {


            score++;
            scoreText.text = score.ToString();
            //print(score);
        }


    }
    //Dekrementacja pkt zycia 
    public void DecreaseLife()
    {
        //Jeżeli zycie jest powyzej 0 to  może spadać  o 1.
        if (live > 0)
        {
            live--;
            print(live);
            //Za każdym razem jak spadnie nam poziom zycia zniknie nam serduszko
            liveHolder.transform.GetChild(live).gameObject.SetActive(false);
        }
        if (live <= 0)
        {
            gameover = true;
            GameOver();
        }
    }
    public void GameOver()
    {
        //Wtrzymuje spawn cukierków
        CandySpawner.instance.StopSpawningCandies();
        //Jezeli nastąpi GameOver nie bedzie mogli poruszać się postacią
        GameObject.Find("Player").GetComponent<PlayerController>().CanMove = false;
        GameOverPanel.SetActive(true);



        print("GameOver()");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
