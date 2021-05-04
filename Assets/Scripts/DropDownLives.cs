using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownLives : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown MyDropDown;
    public Text MyChoice;

    // Update is called once per frame
    public void ShowChoice()
    {
        switch(MyDropDown.value)
        {
            case 1:
                MyChoice.text = "1";
                PlayerPrefs.SetInt("lives", 1);
                break;
            case 2:
                MyChoice.text = "2";
                PlayerPrefs.SetInt("lives", 2);
                break;
            case 3:
                MyChoice.text = "3";
                PlayerPrefs.SetInt("lives", 3);
                break;
            case 4:
                MyChoice.text = "4";
                PlayerPrefs.SetInt("lives", 4);
                break;
            case 5:
                MyChoice.text = "5";
                PlayerPrefs.SetInt("lives", 5);
                break;
            case 6:
                MyChoice.text = "6";
                PlayerPrefs.SetInt("lives", 6);
                break;
            case 7:
                MyChoice.text = "7";
                PlayerPrefs.SetInt("lives", 7);
                break;
            case 8:
                MyChoice.text = "8";
                PlayerPrefs.SetInt("lives", 8);
                break;
            case 9:
                MyChoice.text = "9";
                PlayerPrefs.SetInt("lives", 9);
                break;
            default:
                MyChoice.text = "Select number of lives";
                break;
        }
    }
}