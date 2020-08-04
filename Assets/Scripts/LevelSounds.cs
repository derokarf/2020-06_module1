using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSounds : MonoBehaviour
{
    private enum needPlay{
        BackgroundSound,
        WinSound,
        GameOverSound,
        ClickButtonSound
    }

    private SoundPlay backgroundSound;
    private SoundPlay winSound;
    private SoundPlay gameOverSound;
    private SoundPlay clickButtonSound;
    void Awake()
    {
        SoundPlay[] sounds = GetComponentsInChildren<SoundPlay>();
        foreach (SoundPlay sound in sounds) {
            switch (sound.name) {
                case "BackgroundSound":
                    backgroundSound = sound;
                    break;
                case "WinSound":
                    winSound = sound;
                    break;
                case "GameOverSound":
                    gameOverSound = sound;
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

    public void playWin() {
        play(needPlay.WinSound);
    }

    public void playGameOver() {
        play(needPlay.GameOverSound);
    }

    public void playClick() {
        play(needPlay.ClickButtonSound);
    }

    private void play(needPlay sound) {
        switch(sound) {
            case needPlay.BackgroundSound:
                backgroundSound.Play();
                break;
            case needPlay.GameOverSound:
                backgroundSound.Stop();
                gameOverSound.Play();
                break;
            case needPlay.WinSound:
                backgroundSound.Stop();
                winSound.Play();
                break;
            case needPlay.ClickButtonSound:
                clickButtonSound.Play();
                break;
        }
    }

}
