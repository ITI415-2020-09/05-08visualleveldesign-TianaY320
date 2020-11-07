using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    
    public Text scoreGT;
    [Header("Set Dynamically")]
   
    public GameObject selectHalo;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("FoodCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    void Awake()
    {
        Transform selectHaloTrans = transform.Find("SelectHalo");
        selectHalo = selectHaloTrans.gameObject;
        selectHalo.SetActive(false);
    }
    void OnMouseEnter()
    {
        selectHalo.SetActive(true);
    }

    void OnMouseExit()
    {
        selectHalo.SetActive(false);
    }

    void OnCollisionEnter(Collision coll)
    {

        GameObject collidedWith = coll.gameObject;

        if (collidedWith.tag == "Cow")
        {
            Destroy(collidedWith); // Destroy what we hit
            int score = int.Parse(scoreGT.text);
            score += 10;
            scoreGT.text = score.ToString();
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
        if (collidedWith.tag == "Pig")
        {
            Destroy(collidedWith); // Destroy what we hit
            int score = int.Parse(scoreGT.text);
            score += 10;
            scoreGT.text = score.ToString();
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
        if (collidedWith.tag == "Chicken")
        {
            Destroy(collidedWith); // Destroy what we hit
            int score = int.Parse(scoreGT.text);
            score += 10;
            scoreGT.text = score.ToString();
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
        if (collidedWith.tag == "Fish")
        {
            Destroy(collidedWith); // Destroy what we hit
            int score = int.Parse(scoreGT.text);
            score += 20;
            scoreGT.text = score.ToString();
            if (score > HighScore.score)
            {
                HighScore.score = score;
            }
        }

    }
}

