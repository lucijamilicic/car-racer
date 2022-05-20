using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    [SerializeField] Button playButton;
    public float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = playButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        Vector3 direction = new Vector3(horizontal * 0.05f, 0f, speed);
        transform.Translate(direction);
        
    }

    void TaskOnClick(){

        speed = 0.15f;
        
	}

    //  void OnTriggerEnter(Collider other) {
    //  if(other.gameObject.tag == "Booster")
    //  {
    //     Destroy(other.gameObject);
    //     speed = 0.3f;
    //  }
// //  }
//     private void OnCollisionEnter(Collision collision)
//    {
//        if(collision.gameObject.tag == "Booster") 
//        {
//             Destroy(collision.gameObject);
//             speed = 0.5f;
//        }
//    }

}
