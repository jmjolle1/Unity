using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	
	public Rigidbody projectile;
	public Transform Spawnpoint;
	public int shootSpeed;
	public Renderer rend;

	
	void Update () {
		if(Input.GetButtonDown("Fire2")){
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);
			clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*shootSpeed);
			
		}

	}
	
}
	


