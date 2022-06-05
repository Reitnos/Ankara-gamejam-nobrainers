using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyScript : MonoBehaviour
{
    private int playtime = 0;
    private int explosionCount = 0;
    private bool moveToward = false;
    private GameObject colZone;
    [SerializeField] private GameObject colEffect;
    public int enemyPower;
    public static bool lose = false;
    public float counter = 0;
    public float counter2 = 0;
    [SerializeField] private GameObject nextLevel;
    [SerializeField] private GameObject loseLevel;
    void Start()
    {
        colZone = GameObject.Find("collisionZone");
        enemyPower = GameObject.Find("enemyScore").GetComponent<EnemyPower>().enemyPower;
    }
  

    // Update is called once per frame
    void Update()
    {
        if (EndGame.endgame && playtime == 0)
        {

            playtime++;
           

            gameObject.transform.position = gameObject.transform.position + new Vector3(23f, -5.5f, +4f);
            gameObject.transform.Rotate(new Vector3(0, -30f, 0));
            moveToward = true;

          
            




        }
        if (moveToward)
        {
            Vector3 destination = new Vector3(gameObject.transform.position.x, colZone.transform.position.y, colZone.transform.position.z);
            if (counter < 1.5)
            {
                counter += Time.deltaTime;
            }
            if (counter > 1.4f)
            {
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, destination, 6f * Time.deltaTime);
                float distance = Vector3.Distance(gameObject.transform.position, colZone.transform.position);
                if (distance < 5f && explosionCount < 10)
                {
                    explosionCount++;
                    Debug.Log("Explosion");
                    GameObject effect = Instantiate(colEffect, colZone.transform.position - new Vector3(+5.5f, -2f, 1f), colEffect.transform.rotation);
                    
                    
                   

                }
                if(explosionCount == 10)
                {

                    if (counter < 1.5)
                    {
                        counter += Time.deltaTime;
                    }
                    if (counter > 1.4f)
                    {
                        if (enemyPower < powerManager.gridPower)
                        {
                            Debug.Log("You won");


                            nextLevel.SetActive(true);
                            Destroy(gameObject);

                        }
                        else
                        {
                            lose = true;
                            loseLevel.SetActive(true);

                        }


                    }
                }
          //  gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, destination, 6f * Time.deltaTime);
           
            }
        }

    }
}
