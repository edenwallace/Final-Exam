using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerName : MonoBehaviour
{
    public InputField PlayerName; 
    public string myPlayerName;
    public Text ShowName; 
    


    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("Name", myPlayerName);
    }

    

    public void DisplayName() {
        myPlayerName = PlayerName.text;
        ShowName.text = myPlayerName;
    }
}