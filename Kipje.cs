using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kipje : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager.instance.Kipje();
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }

    void OnTriggerExit(Collider other)
    {
        GameManager.instance.KipjeDisable();
    }

}
