using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
            GetComponent<SpriteRenderer>().enabled = false;
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
