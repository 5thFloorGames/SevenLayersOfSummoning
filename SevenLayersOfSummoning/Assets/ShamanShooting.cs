﻿using UnityEngine;
using System.Collections;

public class ShamanShooting : MonoBehaviour {

	public GameObject bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject firedBullet = (GameObject)Instantiate (bullet, transform.position, transform.rotation);
			Rigidbody2D bulletrb = firedBullet.GetComponent<Rigidbody2D> ();
			bulletrb.AddForce (transform.up * (-1) * 200f);
			Physics2D.IgnoreCollision(firedBullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
		}
	}
}
