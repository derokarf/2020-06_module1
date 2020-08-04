using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSounds : MonoBehaviour
{
    private enum needPlay{
        BackgroundSound,
        ClickButtonSound
    }

    private SoundPlay backgroundSound;
    private SoundPlay clickButtonSound;

    void Awake() {
        SoundPlay[] sounds = GetComponentsInChildren<SoundPlay>();
        foreach (SoundPlay sound in sounds) {
            switch (sound.name) {
                case "BackgroundSound":
                    backgroundSound = sound;
                    break;
                case "ClickButtonSound":
                    clickButtonSound = sound;
                    break;                                                            
            }
        }
    }

    public void playBackground() {
        play(needPlay.BackgroundSound);
    }
    public void playClick() {
        play(needPlay.ClickButtonSound);
    }

    private void play(needPlay sound) {
        switch(sound) {
            case needPlay.BackgroundSound:
                backgroundSound.Play();
                break;
            case needPlay.ClickButtonSound:
                clickButtonSound.Play();
                break;
        }
    }

}
