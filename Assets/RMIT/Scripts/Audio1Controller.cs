using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio1Controller : MonoBehaviour {

    public AudioClip[] m_VoiceLines;
    private AudioSource m_AudioSource;

	// Use this for initialization
	void Start ()
    {
        m_AudioSource = this.GetComponent<AudioSource>();
        StartCoroutine(PlayScenario());
	}

    IEnumerator PlayScenario()
    {
        // All manually timed for an initial runthrough
        yield return new WaitForSeconds(1f);


        StartCoroutine(PlaySound(m_VoiceLines[0]));
        yield return new WaitForSeconds(m_VoiceLines[0].length);
    }

    IEnumerator PlaySound(AudioClip a)
    {
        if (a != null)
        {
            m_AudioSource.clip = a;
            m_AudioSource.Play();
        }

        yield return null;
    }
}
