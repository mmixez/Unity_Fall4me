using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicSound : MonoBehaviour
{
    AudioSource audioSrc;
    public bool startPlay;
    bool currentlyPlaying=false;
    public bool playOnStart;

    // Start is called before the first frame update
    void Start(){
        audioSrc=GetComponent<AudioSource>();
        if(playOnStart){
            startPlay=true;
        }else{
            startPlay=false;
        }
    }

    // Update is called once per frame
    void Update(){}

    public void Play(){
        if(startPlay==true && currentlyPlaying==false){
            audioSrc.Play();
            currentlyPlaying=true;
        }else if(startPlay==false && currentlyPlaying==true){
            audioSrc.Stop();
            currentlyPlaying=false;
        }
    }
}
