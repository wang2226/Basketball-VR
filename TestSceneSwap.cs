using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestSceneSwap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.collider.gameObject.name);
        Debug.Log(SceneManager.GetActiveScene().name);

        if (collision.collider.gameObject.CompareTag("Door"))
        {
            if (SceneManager.GetActiveScene().name == "BasketballVR")
            {
                SceneManager.LoadScene("BasketballVR 2");
            }
            else if (SceneManager.GetActiveScene().name == "BasketballVR 2")
            {
                SceneManager.LoadScene("BasketballVR");
            }
        }
    }
}
