﻿using UnityEngine;

public class AudioManager : MonoBehaviour
{
   [SerializeField]
   private AudioSource ambienceSource = default;
   [SerializeField]
   private AudioClip music = default;
   private static AudioManager _instance;

   void Awake()
   {
       _instance = this;
       if (music) {
           ambienceSource.loop = true;
           ambienceSource.clip = music;
           ambienceSource.Play();
       }
   }

   public static void SetAmbience(AudioClip audioClip)
   {
       _instance.ambienceSource.Stop();
       _instance.ambienceSource.clip = audioClip;
       _instance.ambienceSource.Play();
   }
}