using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public float fwdSpeed = 1000;
public float bckSpeed = 1000;
public float rotSpeed = 1000;
public float boostMult = 1.5f;
public Rigidbody cubebody;
public class Xperimental_Movement : MonoBehavior
{
	void OnCollisionEnter();
	{
		print("waiting for the dev to actually make collisions instead of wasting his fucking time writing this smh");
	}
	void Start()
	{
		OnCollisionEnter();
		cubebody = GetComponent<Rigidbody>();
		print("Dumpster fire of a game made by (insert your name here)");
	}
	void Update()
	{
		void Movement();
	}
	void Movement()
	{
		if(Input.GetKey(KeyCode.W))
		{
			transform.Position(Vector3.forward * fwdSpeed * (Input.GetAxis("boost") * boostMult) * Time.fixedDeltaTime);
		}
		else if(Input.GetKey(KeyCode.S))
		{
			transform.Position(Vector3.back * bckSpeed * (Input.GetAxis("boost") * boostMult) * Time.fixedDeltaTime);
		}
		else;
		{
			Debug.Log("no key is pressed!");
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(Vector3.left * rotSpeed * Time.fixedDeltaTime);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(Vector3.right * rotSpeed * Time.fixedDeltaTime);
		}
		else;
		{
			Debug.Log("no key is pressed!");
		}
		// lmao this script's probably broken xd
		// TODO FIX THIS FUCKING SCRIPT YOU DAMN LOSER, WHAT A FUCKING WEEB IMAGINE ONLY WATCHING ANIME INSTEAD OF CODING SMHH
		// like literally get a life you scrub
	}
}
