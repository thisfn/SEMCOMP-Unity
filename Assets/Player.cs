﻿using UnityEngine;

public class Player : MonoBehaviour
{
	public Rigidbody2D rb;
	public float force;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			rb.velocity = Vector3.up * force;
		}
	}
}