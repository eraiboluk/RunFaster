using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScritp : MonoBehaviour
{
    public GameObject GameUI;
    public GameObject MainMenu;
    
    void Start()
    {

        System.Threading.Thread.Sleep(1000);
        MainMenu.SetActive(false);
        GameUI.SetActive(true);
        
        
    }

}
