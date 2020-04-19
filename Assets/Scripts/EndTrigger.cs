using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Game_Manager gameManager;

    void OnTriggerEnter ()
    {
        Debug.Log("Succeed");
        gameManager.CompleteLevel();
    }
}
