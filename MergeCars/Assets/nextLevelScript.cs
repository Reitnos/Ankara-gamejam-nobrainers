using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelScript : MonoBehaviour
{
    public void  nextLevel()
    {
        coinText.coinCount = 100;
        powerManager.gridPower = 0;
        EndGame.endgame = false;
        enemyScript.lose = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
