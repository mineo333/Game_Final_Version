using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    //This is for the forest
	//coolDownperiod in seconds has to be 1 second less than the desired time
	private float timeStamp;
	private float coolDownPeriodInSeconds = 89;
    public Canvas Canvas;
    public Canvas NewCanvas;
    public GameObject Tmer;
    public GameObject Score;
	void Start(){
		timeStamp = Time.time + coolDownPeriodInSeconds;
	}
	public Text timerLabel;

	private float time;

	void Update() {
		time += Time.deltaTime;

		var minutes = time / 120; //Divide the guiTime by sixty to get the minutes.
		var seconds = time % 60;//Use the euclidean division for the seconds.
		var fraction = (time * 100) % 100;

		//update the label value
		timerLabel.text = string.Format ("{0:00} : {1:00} : {2:000}", minutes, seconds, fraction);

			if (timeStamp <= Time.time)
			{
            
            Canvas.enabled = false;
            NewCanvas.enabled = true;
            Debug.Log ("You Lose");
			}

}
}
