using UnityEditor;
using UnityEngine;

public class MenuDiceLogic : MonoBehaviour
{
    public GameObject canvas;
    public bool isActive = true;

    public void DiceClick(GameObject prefab) {
        canvas.SetActive(false);
        this.SpawnDice(prefab);
    }

    public void ToggleCanvas() {
        isActive = !isActive;
        if (isActive)
        {
            canvas.SetActive(false);
        }
        else
        {
            canvas.SetActive(true);
        }

    }

    public void ShowCanvas(bool state) {
        canvas.SetActive(state); 
    }

    public void SpawnDice(GameObject prefab)
    {
        Instantiate(prefab, GetMousePosition(), Quaternion.identity);
    }

    private Vector3 GetMousePosition()
    {
        Vector3 positionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        positionInWorld.z = 0;
        return positionInWorld;
    }

    public void ResetBtn()
    {
        GameObject[] dices = GameObject.FindGameObjectsWithTag("dice");
        foreach (GameObject die in dices)
        {
            Destroy(die);
        }
    }
}
