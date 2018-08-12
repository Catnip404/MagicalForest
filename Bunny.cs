using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager.instance.Bunny();
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }

    void OnTriggerExit(Collider other)
    {
        GameManager.instance.BunnyDisable();
    }

}
