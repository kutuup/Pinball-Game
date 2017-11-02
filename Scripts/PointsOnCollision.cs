using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsOnCollision : MonoBehaviour {

    public GameObject manager;
    GameManager gm;
    public int scoreValue;
    public GameObject ball;

	// Use this for initialization
	void Start () {

        if(scoreValue==0)
        {
            scoreValue = 100;
        }
        manager = GameObject.FindGameObjectWithTag("GameManager");
        ball = GameObject.FindGameObjectWithTag("Ball");
        gm = manager.GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Hit");
        if(col.gameObject.tag == "Ball")
        {
            gm.StartCoroutine(gm.AddScore(scoreValue));
        }
    }
}


