using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    public TextMesh timer1;
    public TextMesh timer2;
    public TextMesh scoreText;
    public TextMesh scoreText2;
    public float timer;
    bool end = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        timer1.text = timer.ToString() + "s left";
        timer2.text = timer.ToString() + "s left";
        if (timer < 0 && !end)
        {
            timer1.text = "Game over \n teleport to restart the game";
            timer2.text = "Game over \n teleport to restart the game";
            scoreText.text = "Your final score is " + scoreText.text;
            scoreText2.text = "Your final score is " + scoreText.text;
            end = true;
        }
    }
}
