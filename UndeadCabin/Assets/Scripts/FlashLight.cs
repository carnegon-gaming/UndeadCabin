using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {
    private Light myLight;
    private AudioSource mySound;
    public AudioClip soundOn;
    public AudioClip soundOff;

	// Use this for initialization
	void Start () {
        myLight = GetComponent<Light>();
        mySound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse1)){
            if(myLight.enabled == false){
                myLight.enabled = true;
                mySound.clip = soundOn;
                mySound.Play();
            }
            else{
                myLight.enabled = false;
                mySound.clip = soundOff;
                mySound.Play();
            }
            }
        }	

}
