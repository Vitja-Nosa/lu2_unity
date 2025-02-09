using System;
using UnityEngine;

/*
* The GameObject also needs a collider otherwise OnMouseUpAsButton() can not be detected.
*/
public class Draggable: MonoBehaviour
{
    public MenuDiceLogic MenuDiceLogic;
    public Transform trans;
 
    private bool isDragging = true;

    public void Start()
    {
        GameObject canvas = GameObject.Find("MenuDiceLogic");
        MenuDiceLogic = canvas.GetComponent<MenuDiceLogic>();
    }
    public void StartDragging()
    {
        isDragging = true;
    }

    public void Update()
    {
        if (isDragging)
            trans.position = GetMousePosition();
    }

    private void OnMouseUpAsButton()
    {
        MenuDiceLogic.ShowCanvas(false);
        isDragging = !isDragging;

        if (!isDragging)
        {
            MenuDiceLogic.ShowCanvas(true);
        }
    }

    private Vector3 GetMousePosition()
    {
        Vector3 positionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        positionInWorld.z = 0;
        return positionInWorld;
    }

}
