using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TaskOnClick : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(UpdateScene);
    }

    private void UpdateScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
