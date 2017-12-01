using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int JumpForce;
	public int moveVelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space"))
		 //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
		
		{
			this.GetComponent<Rigidbody2D> ().AddForce(new Vector2(0,JumpForce));
		}
        
		this.GetComponent<Rigidbody2D> ().velocity = new Vector2( moveVelocity,
		               this.GetComponent<Rigidbody2D> ().velocity.y);

	}
  
   void OnTriggerEnter2D(Collider2D c)
   {
	   if(c.tag=="Obstacle")
	   {
        GameObject.Destroy (this.gameObject);
	   }
   }


}
