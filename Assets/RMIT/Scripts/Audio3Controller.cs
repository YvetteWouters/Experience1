using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio3Controller : MonoBehaviour {

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
        yield return new WaitForSeconds(3f);


        StartCoroutine(PlaySound(m_VoiceLines[0]));
        yield return new WaitForSeconds(m_VoiceLines[0].length);

        StartCoroutine(PlaySound(m_VoiceLines[1]));
        yield return new WaitForSeconds(m_VoiceLines[1].length);

        StartCoroutine(PlaySound(m_VoiceLines[2]));
        yield return new WaitForSeconds(m_VoiceLines[2].length);

        StartCoroutine(PlaySound(m_VoiceLines[3]));
        yield return new WaitForSeconds(m_VoiceLines[3].length);

        StartCoroutine(PlaySound(m_VoiceLines[4]));
        yield return new WaitForSeconds(m_VoiceLines[4].length);

        StartCoroutine(PlaySound(m_VoiceLines[5]));
        yield return new WaitForSeconds(m_VoiceLines[5].length);

        StartCoroutine(PlaySound(m_VoiceLines[6]));
        yield return new WaitForSeconds(m_VoiceLines[6].length);

        StartCoroutine(PlaySound(m_VoiceLines[7]));
        yield return new WaitForSeconds(m_VoiceLines[7].length);

        StartCoroutine(PlaySound(m_VoiceLines[8]));
        yield return new WaitForSeconds(m_VoiceLines[8].length);

        StartCoroutine(PlaySound(m_VoiceLines[9]));
        yield return new WaitForSeconds(m_VoiceLines[9].length);
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
