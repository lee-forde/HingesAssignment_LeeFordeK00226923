using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public Rigidbody2D rb2d;

    public HingeJoint2D HingeTrap;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.name == "Hero")
        {
            RigidbodyType2D.Kinematic
        }
    }

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
