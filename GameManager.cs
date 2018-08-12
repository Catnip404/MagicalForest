using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    internal void myDialogueFunctiond()
    {
        throw new NotImplementedException();
    }

    public GameObject youWinText;
    public GameObject youLoseText;
    public GameObject TextWitch;
    public GameObject TextKipje;
    public GameObject TextSquirrel;
    public GameObject TextBunny;
    public GameObject scoreTextObject;

    public int score;
    Text scoreText;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);

        scoreText = scoreTextObject.GetComponent<Text>();
        scoreText.text = "Crystals: " + score.ToString();
    }

    public void Collect(int passedValue, GameObject passedObject)
    {
        //Zet de mesh renderer uit, object word ontzichtbaar, collider ook uit
        passedObject.GetComponent<Renderer>().enabled = false;
        passedObject.GetComponent<Collider>().enabled = false;

        //Destory collectable
        Destroy(passedObject, 1.5f); // voert de code pas uit NA 1.5 secoden

        //Update score value
        score = score + passedValue;
        scoreText.text = "Crystals: " + score.ToString();

        //if (score == 3) (werkt niet met delay)
        //Application.LoadLevel("Menu"); (werkt niet met delay)

        if (score == 10)
        {
            Invoke("ChangeLevelToWitch", 3.0f);
            GameManager.instance.Win();
        }

    }

    void ChangeLevelToMenu()
    {
        Application.LoadLevel("Menu");
    }

    void ChangeLevelToWitch()
    {
        Application.LoadLevel("witchHouse");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 0);
        }
    }

    public void Win()
    {
        youWinText.SetActive(true);
    }

    public void Lose()
    {
        youLoseText.SetActive(true);
        Invoke("ChangeLevelToMenu", 4.0f);
    }

    //WITCH SCRIPTS
    public void Witch()
    {
        TextWitch.SetActive(true);
    }

    public void WitchDisable()
    {
        TextWitch.SetActive(false);
    }

    //KIPJE SCRIPTS
    public void Kipje()
    {
        TextKipje.SetActive(true);
    }

    public void KipjeDisable()
    {
        TextKipje.SetActive(false);
    }

    //SQUIRREL SCRIPTS
    public void Squirrel()
    {
        TextSquirrel.SetActive(true);
    }

    public void SquirrelDisable()
    {
        TextSquirrel.SetActive(false);
    }

    //BUNNY SCRIPTS
    public void Bunny()
    {
        TextBunny.SetActive(true);
    }

    public void BunnyDisable()
    {
        TextBunny.SetActive(false);
    }

}