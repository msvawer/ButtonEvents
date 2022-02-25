using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class SongManager : MonoBehaviour
{
    public AudioSource m_MyAudioSource;

    //public AudioClip[] reggaeSongsArray = new AudioClip[4];

    public AudioClip song1;
    public AudioClip song2;
    public AudioClip song3;
    public AudioClip song4;

    public float volume = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "JB1")
        {
            m_MyAudioSource.Stop(); //Stop current song
                                    
            //Set new clip 
            m_MyAudioSource.PlayOneShot(song1, volume);

            m_MyAudioSource.Play();

        }

        if(other.gameObject.tag == "JB2")
        {
            m_MyAudioSource.Stop(); //Stop current song

            //Set new clip 
            m_MyAudioSource.PlayOneShot(song2, volume);

            m_MyAudioSource.Play();

        }


        if (other.gameObject.tag == "JB3")
        {
            m_MyAudioSource.Stop(); //Stop current song

            //Set new clip 
            m_MyAudioSource.PlayOneShot(song3, volume);

            m_MyAudioSource.Play();

        }

        if (other.gameObject.tag == "JB4")
        {
            m_MyAudioSource.Stop(); //Stop current song

            //Set new clip 
            m_MyAudioSource.PlayOneShot(song4, volume);

            m_MyAudioSource.Play();

        }
    }

}
