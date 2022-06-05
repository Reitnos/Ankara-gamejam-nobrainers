using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    public List<GameObject> gridList = new List<GameObject>();
    public List<GameObject> emptyGrid = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
       // pushOne();
        
    }

   public void pushOne()
    {
        gridList.AddRange(GameObject.FindGameObjectsWithTag("grid"));
        foreach (GameObject gmob in gridList)
        {
            if (gmob.layer == 6)
            {
                emptyGrid.Add(gmob);
            }
        }
        if (emptyGrid.Count > 0)
        {
            GameObject gridToSpawn = emptyGrid[Random.Range(0,gridList.Count-1)];
            if(prefab.tag == "1" || prefab.tag == "2" || prefab.tag == "3" || prefab.tag == "4")
            {
                GameObject prefabToSpawn = Instantiate(prefab, gridToSpawn.transform.position +
                new Vector3(0, 0.8f, 0),
                prefab.transform.rotation);
            }
            else
            {

                GameObject prefabToSpawn = Instantiate(prefab, gridToSpawn.transform.position +
                    new Vector3(0, 0.3f, 0),
                    prefab.transform.rotation);
            }
            gridList.Remove(gridToSpawn);
            gridToSpawn.layer = 0;
            gameObject.GetComponent<Button>().interactable = false;
            coinText.coinCount -= 50;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
