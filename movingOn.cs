using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movingOn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    public void Update()

    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
    }
}
