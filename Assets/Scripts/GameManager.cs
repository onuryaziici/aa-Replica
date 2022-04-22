using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotater rotater;
    public Spawner spawner;

    public Animator animator;
    public void EndGame()
    {
        if (gameHasEnded)
            return;
        
        rotater.enabled = false;
        spawner.enabled = false;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
        Debug.Log("END GAME");
    }
}
