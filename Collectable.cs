using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int value;
    public float rotateSpeed;
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);

	}

    private void OnTriggerEnter()
    {
        //Collect Functie
        GameManager.instance.Collect(value, gameObject);

        //Speel Geluid
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
     }

}
