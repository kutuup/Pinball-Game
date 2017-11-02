using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

    // Use this for initialization
    public KeyCode key;
    public Rigidbody rigid;
    public int force;
    
	void Start () {
        rigid = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

    void Update()
    {
     if(Input.GetKeyDown(key))
        {
            rigid.AddForce(new Vector3(0,0,force));
        }   
    }
}
