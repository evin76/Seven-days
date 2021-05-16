using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onMouseDown : MonoBehaviour
{
    bool isOpen = false;
    bool isCollision = false;
    bool itWas = false;
    public Rigidbody2D rb;
    float posX;
    float posY;

    void OnGUI() 
    {
        if(!itWas)
        {
            if (isOpen)
            {
                posX = rb.position.x;
                posY = rb.position.y;
                GUI.Box(new Rect(posX + 5,posY + 10, 210, 50), "Срубить дерево?");
                if (GUI.Button(new Rect(posX + 10, posY + 30, 100, 20), "Да"))
                {
                    Debug.Log("Да");
                    itWas = true;
                }
                if (GUI.Button(new Rect(posX + 110, posY + 30, 100, 20), "Нет"))
                {
                    Debug.Log("Нет");
                    isOpen = false;
                }
            }
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        isCollision = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isCollision = false;
    }

    void OnMouseDown()
    {
        if (isOpen) isOpen = false;
        if (isCollision) isOpen = true;
    }
}
