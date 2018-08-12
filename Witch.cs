using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameManager.instance.Witch();
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }

    void OnTriggerExit(Collider other)
    {
        GameManager.instance.WitchDisable();
    }

}
