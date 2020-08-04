using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSounds : MonoBehaviour
{
    private SoundPlay attack;
    private SoundPlay takeDamage;
    private SoundPlay death;
    private SoundPlay steps;

    private enum needPlay{
        Attack,
        TakeDamage,
        Death,
        Steps
    }

    void Awake()
    {
        SoundPlay[] sounds = GetComponentsInChildren<SoundPlay>();
        foreach (SoundPlay sound in sounds) {
            switch (sound.name) {
                case "Attack":
                    attack = sound;
                    break;
                case "TakeDamage":
                    takeDamage = sound;
                    break;
                case "Death":
                    death = sound;
                    break;
                case "Steps":
                    steps = sound;
                    break;                                                            
            }
        }
    }

    public void playAttack() {
        attack.Play();
    }

    public void playTakeDamage() {
        takeDamage.Play();
    }

    public void playDeath() {
        death.Play();
    }

    public void playSteps() {
        steps.Play();
    }

    public void stopSteps() {
        steps.Stop();
    }


}
