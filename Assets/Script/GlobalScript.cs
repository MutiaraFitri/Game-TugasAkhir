using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalScript : MonoBehaviour
{
    public static GlobalScript Instance;
    public int score_a;
    public int nyawa_a =3;
    public Text textnyawa;
    public Text textscore_a;
    public int min_life = 0;

    public Image[] hp;
    public GameObject panelGameOver;
    //untuk life
    // public GameObject heart1, heart2, heart3, gameOver;
    public GameObject gameOver;
    public bool isGameOver = false;
    public int health;
  
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        textnyawa.text = "life : " + nyawa_a;
        health = 3;
        // heart1.gameObject.SetActive (true);
        // heart2.gameObject.SetActive (true);
        // heart3.gameObject.SetActive (true);
        gameOver.gameObject.SetActive (false);

    }

    // Update is called once per frame
    void Update()
    {
        print("Score = " + score_a);

        if(nyawa_a == 0) {
            isGameOver = true;
            panelGameOver.SetActive(true);
        }

        for(int i=0; i<health; i++) {
            if(nyawa_a < health)
            hp[nyawa_a].enabled = false;
        }

        Debug.Log(nyawa_a);
            // switch (health) {
            //     case 3:
            //         heart1.gameObject.SetActive (true);
            //         heart2.gameObject.SetActive (true);
            //         heart3.gameObject.SetActive (true);
            //         break;
            //     case 2:
            //         heart1.gameObject.SetActive (true);
            //         heart2.gameObject.SetActive (true);
            //         heart3.gameObject.SetActive (false);
            //         break;
            //     case 1:
            //         heart1.gameObject.SetActive (true);
            //         heart2.gameObject.SetActive (false);
            //         heart3.gameObject.SetActive (false);
            //         break;
            //     case 0:
            //         heart1.gameObject.SetActive (false);
            //         heart2.gameObject.SetActive (false);
            //         heart3.gameObject.SetActive (false);
            //         gameOver.gameObject.SetActive (true);
            //         Time.timeScale = 0;
            //         break;
            // }
    }


    public void AddScoreA(){
        score_a ++;
        textscore_a.text = "Score : " + score_a;
    }

    public void Life(){
        nyawa_a --;
        textnyawa.text = "life : " + nyawa_a;
        // if(nyawa_a == min_life){
        //     GameOver("Player");
        // }
    }

    public void Restart(){
        SceneManager.LoadScene("dessert");
    }
}