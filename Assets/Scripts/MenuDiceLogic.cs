using UnityEngine;

public class MenuDiceLogic : MonoBehaviour
{
    public GameObject canvas;

    public void DiceClick(int number) {
        canvas.SetActive(false);
        Debug.Log($"Clicked on the dice { number }");
    
    }

    public void SpawnDice()
    {
        // spawn the dice here
    }
}
