using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour {

    public static int moveSpeed = 1;

    public Vector3 userDirection = Vector3.right;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(userDirection * moveSpeed * Time.deltaTime);
	}
}
