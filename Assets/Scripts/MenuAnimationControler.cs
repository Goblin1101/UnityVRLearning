using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimationControler : MonoBehaviour
{

    
    GameObject subMenu;

    



    public void OpenLaunchMenu (){

        subMenu = GameObject.Find("GameModes");
        subMenu.SetActive(true);
    }

    public void CloseLaunchMenu(){
        subMenu = GameObject.Find("GameModes");
        subMenu.SetActive(false);
    }

    public void OpenInstructionMenu(){

        
subMenu = GameObject.Find("Instructions");
        subMenu.SetActive(true);

    }

    public void CloseInstructionMenu(){
subMenu = GameObject.Find("Instructions");
        subMenu.SetActive(false);
    }
}
