using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSound : MonoBehaviour
{
    private AudioSource mySound;
    public AudioClip soundOn;

    // Use this for initialization
    void Start()
    {
        mySound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mySound.clip = soundOn;
            mySound.Play();
        }
    }
}
