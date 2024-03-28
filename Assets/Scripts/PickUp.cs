using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject Item;
    public GameObject Image;
    public WinDetect a;
    public GameObject Win;
    
    // Start is called before the first frame update
    void Start() { 

        PickUpText.SetActive(false);
        a = Win.GetComponent<WinDetect>();
    }
    private void OnTriggerStay (Collider other) { 

            if (other.gameObject.tag  == "Player") {

                PickUpText.SetActive(true); 

                if (Input.GetKey(KeyCode.E)) { 

                    Item.SetActive(false); 
                    PickUpText.SetActive(false); 
                    Image.SetActive(false);
                    a.sayi++;

                }
            }
    }
    private void OnTriggerExit (Collider other) { 

        PickUpText.SetActive(false); 
    }
}

