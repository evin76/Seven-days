using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    public bool dialogueActive;
    private Player_Movement player;
    public bool flag = false;

    private void Update()
    {
        HitSpace();
    }

    private void HitSpace()
    {
        if (dialogueActive && Input.GetKeyDown(KeyCode.Space))
        {
            dBox.SetActive(false);
            dialogueActive = false;
            flag = true;
        }
    }


    public void ShowBox(string dialogue)
    {
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
        flag = false;
    }
}
