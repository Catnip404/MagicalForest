using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager.instance.Lose();
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }



}
