using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class regenerate : MonoBehaviour {

    public GameObject ball;
    public GameObject box;
    public GameObject point;
    public GameObject test;

	public GameObject point1;
	public GameObject point2;
	public GameObject point3;
	public GameObject point4;
	public GameObject point5;

	private int count = 0;
    

	// Use this for initialization
	void Start () {
		point2.SetActive (false);
		point3.SetActive (false);
		point4.SetActive (false);
		point5.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    bool UC;

    IEnumerator Example()
    {
        yield return new WaitForSeconds(2);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Floor"))
        {
            Example();
            Destroy(ball);
            ball = Instantiate(ball, new Vector3(box.transform.position.x, box.transform.position.y + 1.0F, box.transform.position.z), box.transform.rotation);
            ball.AddComponent<BounceSounds>();

        }

        /*if (collision.collider.gameObject.CompareTag("Fence"))
        {
			if (SceneManager.GetActiveScene ().name == "BasketballVR 2") {
				if (count == 0) {
					point1.SetActive (false);
					point2.SetActive (true);
				} else if (count == 1) {
					point2.SetActive (false);
					point3.SetActive (true);
				} else if (count == 2) {
					point3.SetActive (false);
					point4.SetActive (true);
				} else if (count == 3) {
					point4.SetActive (false);
					point5.SetActive (true);
				} else {
					count = 0;
				}
				count++;
			}
        }*/
        /*if (collision.collider.gameObject.CompareTag("Fence"))
        {
            Example();
            //Destroy(point);
            Vector3 position = new Vector3(Random.Range(2.0f, 5.0f), 0.7f, Random.Range(-1.0f, 3.0f));
            Instantiate(point, position, Quaternion.identity);
        }*/

    }

    private void OnTriggerEnter(Collider col) {
        //Debug.Log(count);
		if (SceneManager.GetActiveScene ().name == "BasketballVR 2") {
			if (col.name == "UC")
			{
				Example ();
				Destroy (ball);
				if (SceneManager.GetActiveScene ().name == "BasketballVR 2") {
					if (point1.activeInHierarchy== true) {
                        Debug.Log("here1");
						point1.SetActive (false);
						point2.SetActive (true);
						count++;
					} else if (point2.activeInHierarchy== true) {
						Debug.Log ("here2");
						point2.SetActive (false);
						point4.SetActive (true);
                        Debug.Log(point3.activeInHierarchy);
						count++;
					} else if (point3.activeInHierarchy == true) {
                        Debug.Log("here3");
                        point3.SetActive (false);
						point4.SetActive (true);
						count++;
					} else if (point4.activeInHierarchy == true) {
                        Debug.Log("here4");
                        point4.SetActive (false);
						point5.SetActive (true);
						count++;
					} else {
						count = 0;
					}
					//count++;
				}
				//UC = true;
			}
			/*if (col.name == "DC" && UC)
			{
				UC = false;
				//Example();
				//Destroy(point);
				//point = Instantiate(point, new Vector3(Random.Range(2.0f, 5.0f), 2.4f, Random.Range(-1.0f, 3.0f)), box.transform.rotation);
				//if (test.activeInHierarchy)
				//{
				//	test.SetActive(false);
				//}
				//else
				//{
				//	test.SetActive(true);
				//}
			}*/
		}
       
    }
}
