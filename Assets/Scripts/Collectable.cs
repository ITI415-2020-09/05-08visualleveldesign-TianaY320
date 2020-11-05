﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;

    [Header("Set in Inspector")]
    public GameObject prefabFish;
    public GameObject prefabCow;
    public GameObject prefabPig;
    public GameObject prefabChicken;

    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(this.gameObject);
            int score = int.Parse(scoreGT.text);
            score += 1;
            scoreGT.text = score.ToString();
        }
    }
}
