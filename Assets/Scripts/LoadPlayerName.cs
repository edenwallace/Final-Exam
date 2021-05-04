using UnityEngine;
using UnityEngine.UI;

public class LoadPlayerName : MonoBehaviour
{

   public string playerName;

   public Text nameText;

    // Update is called once per frame
    void Update()
    {
        playerName = PlayerPrefs.GetString("Name", "No Name");
        nameText.text = "Name: " + playerName;
    }
}