using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BounceSounds : MonoBehaviour {

    //public AudioClip floor;
	//public AudioClip rim;
	//public AudioClip backboard;
	//public AudioClip net;
	//public AudioClip fence;

	//AudioSource audioSource;

	// Use this for initialization
	void Start () {
		//audioSource = gameObject.AddComponent<AudioSource> ();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
        //Debug.Log (collision.collider.name);Assets/Sounds/Floor3.mp3
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        AudioClip floor = Resources.Load("Floor3") as AudioClip;
        AudioClip rim = Resources.Load("Rim") as AudioClip;
        AudioClip backboard = Resources.Load("Backboard") as AudioClip;
        AudioClip net = Resources.Load("Net") as AudioClip;
        AudioClip fence = Resources.Load("Fence") as AudioClip;


    float audioLevel = collision.relativeVelocity.magnitude / 10.0f;

		if(collision.collider.gameObject.CompareTag("Floor")){
            //AudioClip floor = Resources.Load("Floor3") as AudioClip;
            int frequency = floor.frequency;
			float timeLength = (float)(.4);
			int samplesLength = (int)(frequency * timeLength);
			AudioClip newFloor = AudioClip.Create (floor.name + "-sub", samplesLength, 1, frequency, false);
			float[] data = new float[samplesLength];
			floor.GetData (data, (int)(frequency * .4));
			newFloor.SetData (data, 0);

			audioSource.PlayOneShot (newFloor, audioLevel);
		} 
		else if(collision.collider.gameObject.CompareTag("Rim")){
			int frequency = rim.frequency;
			float timeLength = (float)(.5);
			int samplesLength = (int)(frequency * timeLength);
			AudioClip newRim = AudioClip.Create (rim.name + "-sub", samplesLength, 1, frequency, false);
			float[] data = new float[samplesLength];
			rim.GetData (data, (int)(frequency * .3));
			newRim.SetData (data, 0);

			audioSource.PlayOneShot (newRim);//, audioLevel/2);
		} 
		else if(collision.collider.gameObject.CompareTag("Backboard")){
			int frequency = backboard.frequency;
			float timeLength = (float)(.4);
			int samplesLength = (int)(frequency * timeLength);
			AudioClip newBackboard = AudioClip.Create (backboard.name + "-sub", samplesLength, 1, frequency, false);
			float[] data = new float[samplesLength];
			backboard.GetData (data, (int)(frequency * .4));
			newBackboard.SetData (data, 0);

			audioSource.PlayOneShot (newBackboard, audioLevel);
		} 
		else if(collision.collider.gameObject.CompareTag("Net")){
			int frequency = net.frequency;
			float timeLength = (float)(.5);
			int samplesLength = (int)(frequency * timeLength);
			AudioClip newNet = AudioClip.Create (net.name + "-sub", samplesLength, 1, frequency, false);
			float[] data = new float[samplesLength];
			net.GetData (data, (int)(frequency * .1));
			newNet.SetData (data, 0);

			audioSource.PlayOneShot (newNet, audioLevel);
		}
		else if(collision.collider.gameObject.CompareTag("Fence")){
//			int frequency = net.frequency;
//			float timeLength = (float)(.5);
//			int samplesLength = (int)(frequency * timeLength);
//			AudioClip newNet = AudioClip.Create (net.name + "-sub", samplesLength, 1, frequency, false);
//			float[] data = new float[samplesLength];
//			net.GetData (data, (int)(frequency * .1));
//			newNet.SetData (data, 0);

			audioSource.PlayOneShot (fence, audioLevel);
		}
//        else if(collision.collider.gameObject.CompareTag("Door")) {
            //Debug.Log(collision.collider.gameObject.name);
//            Debug.Log(SceneManager.GetActiveScene().name);

  //          if (SceneManager.GetActiveScene().name == "BasketballVR")
//            {
//                SceneManager.LoadScene("BasketballVR 2");
//            }
//            else if (SceneManager.GetActiveScene().name == "BasketballVR 2")
//            {
//                SceneManager.LoadScene("BasketballVR");
//            }

  //      }
	}
}
