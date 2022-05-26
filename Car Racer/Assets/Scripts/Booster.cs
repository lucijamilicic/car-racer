using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Booster : MonoBehaviour
{
    [SerializeField] PlayerMovement player;
    
    private void OnCollisionEnter(Collision collision)
   {
       if(collision.gameObject.tag == "Booster") 
       {
            Destroy(collision.gameObject);
            player.speed = 0.5f;
            StartCoroutine(speedTime());
        }
        if (collision.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("EndGameScene");
        }
    }

    IEnumerator speedTime ()
     {
         yield return new WaitForSeconds(2);
         revertSpeed();
 
 
     }
     
     void revertSpeed ()
     {
        player.speed = 0.15f;
     }
}
