using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public GameObject ball;
    public GameObject spawnPoint;

	// Use this for initialization
	void Start () {
		Debug.Log("HELLO WORLD");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseButtonUp()
    {
        if (GameObject.FindGameObjectWithTag("Ball") == null)
        {
            Instantiate(ball, spawnPoint.transform.position, new Quaternion());
        }
    }

}
