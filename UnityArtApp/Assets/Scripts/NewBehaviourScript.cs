using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Globalization;

public class NewBehaviourScript : MonoBehaviour
{
    private string commentDescription;
    public Text inputText;
    public GameObject textDisplay;

    

    public void StoreComment(){
        
        commentDescription = DateTime.Now.ToString() + ": " + inputText.text + "\x0A"; //Sla tekst op uit inputfield
        
        textDisplay.GetComponent<Text>().text += commentDescription;
        
    } 
}
