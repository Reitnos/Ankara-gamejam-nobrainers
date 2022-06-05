using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public static bool endgame = false;
    private GameObject cam;
    private GameObject enemyCanvas;
    private GameObject playerCanvas;
   
    //List<GameObject> cars = new List<GameObject>();
    //List<string> tags = new List<string>() { "1-1", "1-2", "1-3", "1-4", "2-1", "2-2", "2-3", "2-4", "3-1", "3-2", "3-3", "3-4", "4-1", "4-2", "4-3", "4-4" };
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        playerCanvas = GameObject.Find("playerCanvas");
        enemyCanvas = GameObject.Find("enemyCanvas");
      
    }
    public void startEndAnim()
    {
        playerCanvas.SetActive(false);
        enemyCanvas.SetActive(false);
        
        endgame = true;
        cam.GetComponent<Animator>().enabled = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
