using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour
{
    public void PlayAgainButton() {
       
        SceneManager.LoadScene("SampleScene");
        //Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
    }

    public void QuitButtton() {
        Debug.Log("quit");
        Application.Quit();
    }
}
