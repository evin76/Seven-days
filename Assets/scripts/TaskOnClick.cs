using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TaskOnClick : MonoBehaviour
{
    private Player_Movement player;
    void Start()
    {
        player = FindObjectOfType<Player_Movement>();
        gameObject.GetComponent<Button>().onClick.AddListener(UpdateScene);
    }

    private void UpdateScene()
    {
        SceneManager.LoadScene("newScene");
    }

}
