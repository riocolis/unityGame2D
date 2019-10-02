using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float movespeed;
	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.transform.position.x > transform.position.x) // x positif
		{
			transform.position = new Vector3(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
		}
		else if(Player.transform.position.x < transform.position.x) /// x negatif
		{
			transform.position = new Vector3(transform.position.x - movespeed * Time.deltaTime, transform.position.y);
		}
		if(Player.transform.position.y > transform.position.y) /// y positif
		{
			transform.position = new Vector3(transform.position.x, transform.position.y + movespeed * Time.deltaTime);
		}
		else if(Player.transform.position.y < transform.position.y) /// y negatif
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - movespeed * Time.deltaTime);
		}
	}
}
