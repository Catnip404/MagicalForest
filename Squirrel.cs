using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirrel: MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager.instance.Squirrel();
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }

    void OnTriggerExit(Collider other)
    {
        GameManager.instance.SquirrelDisable();
    }

}
