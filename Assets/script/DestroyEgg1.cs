using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyEgg1 : MonoBehaviour
{
   public GameObject instiationstop;
   public GAMEOVER Game;
   private static int scorestore;
   private static int score = 0;
   private static int life = 3;
   public Text scoreDisplay;
   public GameObject Lives;
   public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Egg")
        {
            score++;
            scorestore++;
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag == "Bomb")
        {
            Destroy(other.gameObject);
            life--;
            TakeDamage();
        }
    } 
    void TakeDamage()
    {
        Destroy(Lives.transform.GetChild(0).gameObject);
    }
    
    void Start()
    {
        Lives = GameObject.Find("Lives") as GameObject;
        life = 3;
        scorestore = 0;
        score = 0;
    }
    
    void Update()
    {
        scoreDisplay.text = score.ToString();
        
        if(life<=0)
        {
            instiationstop.SetActive(false);
            Game.GameEnd();
        }
    }
}