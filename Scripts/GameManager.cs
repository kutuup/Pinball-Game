﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    int score;

    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}

    public IEnumerator AddScore(int s)
    {
        yield return new WaitForSeconds(0f);
        score += s;
    }
}
