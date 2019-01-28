using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    public TextMesh scoreText;
    public TextMesh scoreText2;
    //public TextMesh timer1;
    //public TextMesh timer2;
    //public float timer;
    //bool end = false;
    /*******************************/
    bool UC;
    int scores;
    /*******************************/
    bool UC2;
    int scores2;

    //public int zero;

    // Use this for initialization
    void Start () {
        //Debug.Log(scoreText.text);
	}
	
	// Update is called once per frame
	void Update () {
      /*  timer -= Time.deltaTime;
        timer1.text = timer.ToString() + "s left";
        timer2.text = timer.ToString() + "s left";
        if (timer < 0)
        {
            end = true;
            scoreText.text = "Your final score is " + scores.ToString();
           
            scoreText2.text = "Your final score is " + scores.ToString();
            timer1.text = "Game over \n teleport to restart the game";
            timer2.text = "Game over \n teleport to restart the game";
        }*/
    }

    void OnTriggerEnter(Collider col)
    {
        //		print (BasSucess.ToString());

        if (col.name == "UC" )
        {
            UC = true;
        }
        if (col.name == "DC" && UC)
        {
            UC = false;
            scores+=2;
            scoreText.text = scores.ToString();
        }

        if (col.name == "UC2")
        {
            UC2 = true;
        }
        if (col.name == "DC2" && UC2)
        {
            UC2 = false;
            scores2 += 2;
            scoreText2.text = scores2.ToString();
        }
    }
}
