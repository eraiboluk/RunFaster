using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetect : MonoBehaviour
{   
    public int sayi = 0;
    public GameObject GameUI;
    public GameObject WinScreen;

    void Update()
    {
        if(sayi == 7){

            GameUI.SetActive(false);
            WinScreen.SetActive(true);

        }
    }
}
