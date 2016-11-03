using UnityEngine;
using System.Collections;

public class tankMovement : MonoBehaviour {

	private int Score = 0;
	public int playerHealth = 0;
	public bool death = false;
	public float moveSpeed = 0;
	public float turnSpeed = 0;
	public float hoverSpeed;

	// Use this for initialization
	void Start () {
	Debug.Log("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
	
	var y = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
	var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
	var hover = Input.GetAxis("Fire1") * Time.deltaTime * hoverSpeed;
	transform.Rotate(0,y,0);
	transform.Translate(0,0,z);
	transform.Translate(hover, 0, 0);
	}

	
}
