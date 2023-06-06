using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControllerEnd : MonoBehaviour
{
    [SerializeField] private string endGame = "StartPage";
    

    public void EndGameButton()
    {
        //clickSound.Play();
        SceneManager.LoadScene(endGame);
    }
}
