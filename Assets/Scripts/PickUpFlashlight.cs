using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFlashlight : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject FlashlightOnPlayer;
    // Start is called before the first frame update
    void Start() { 
        FlashlightOnPlayer.SetActive(false); 
        PickUpText.SetActive(false);
    }
    private void OnTriggerStay (Collider other) { 

            if (other.gameObject.tag  == "Player") {

                PickUpText.SetActive(true); 

                if (Input.GetKey(KeyCode.E)) { 

                    this.gameObject.SetActive(false); 
                    FlashlightOnPlayer.SetActive(true); 
                    PickUpText.SetActive(false); 

                }
            }
    }
    private void OnTriggerExit (Collider other) { 

        PickUpText.SetActive(false); 

    }
}
