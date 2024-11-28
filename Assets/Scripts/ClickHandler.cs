using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private GameManager gameManager;
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }
    private void OnMouseDown() {
        gameManager.EndGame();
    }
}
