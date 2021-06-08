using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{
    public string dialogue;
    private Dialogue manager;

    private void Start()
    {
        manager = FindObjectOfType<Dialogue>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetMouseButtonDown(0))
            {
                manager.ShowBox(dialogue);
            }
            else if(Input.GetMouseButtonDown(1))
            {
                manager.HideBox(dialogue);
            }
        }
    }
}
