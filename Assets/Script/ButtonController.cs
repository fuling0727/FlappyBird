using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private string newGameLevel = "NewGame";
    //public AudioSource clickSound;

    public void NewGameButton()
    {
        //clickSound.Play();
        SceneManager.LoadScene(newGameLevel);
    }
}
