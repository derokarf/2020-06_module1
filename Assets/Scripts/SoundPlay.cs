using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public sealed class SoundPlay : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Play()
    {
        _audioSource.clip = _clip;
        _audioSource.Play();
    }

    public void Stop()
    {
        if(_audioSource) _audioSource.Stop();
    }
}
