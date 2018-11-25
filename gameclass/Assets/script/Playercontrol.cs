﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
 {
public Rigidbody2D rb;
public Transform groundCheck;
public Transform startPosition;
public float groundCheckRadius;
public LayerMask whatIsGround;
private bool onGround;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		rb.velocity = new Vector2(3, rb.velocity.y);
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		
		if (Input.GetKey(KeyCode.RightArrow) && onGround)
		{
			rb.velocity = new Vector2 (rb.velocity.x, 5);
	}
}
}
