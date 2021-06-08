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
    public GameObject leftClick;
    public GameObject rightClick;

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
            leftClick.SetActive(true);
            rightClick.SetActive(false);
        }
    }


    public void ShowBox(string dialogue)
    {
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
        flag = false;
        leftClick.SetActive(false);
        rightClick.SetActive(true);
    }

    public void HideBox(string dialogue)
    {
        dialogueActive = false;
        dBox.SetActive(false);
        dText.text = dialogue;
        flag = false;
        leftClick.SetActive(true);
        rightClick.SetActive(false);
    }
}
