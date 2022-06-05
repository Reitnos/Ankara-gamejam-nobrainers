using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;




public class MergeControl : MonoBehaviour
{
    public float counter = 0;
    private GameObject firstTale;
    private Vector3 offset;
  private Vector3 firstClickPos;
  private RaycastHit hit3d;
  private Vector3 firstPos;
  private Vector3 firstScale;
    private int playtime = 0;
    private GameObject toMerge;
    [SerializeField] private GameObject mEffect;
    [SerializeField] private GameObject mEffect2;
    [SerializeField]   private bool coll = false;
    private bool moveToward = false;
    private GameObject colZone;

    public List<GameObject> prefabs = new List<GameObject>();

    private GameObject prefabToUse;
  [SerializeField] private GameObject level2Prefab;


    void OnTriggerEnter(Collider other)
    {
        switch (gameObject.tag)
        {
            case "2":

                switch (other.tag)
                {
                    case "2":

                        prefabToUse = prefabs.Find(x => x.tag == "3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "1-1":

                        prefabToUse = prefabs.Find(x => x.tag == "1-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "2-1":
                        prefabToUse = prefabs.Find(x => x.tag == "2-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "3-1":
                        prefabToUse = prefabs.Find(x => x.tag == "3-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "4-1":
                        prefabToUse = prefabs.Find(x => x.tag == "4-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "3":

                switch (other.tag)
                {
                    case "3":

                        prefabToUse = prefabs.Find(x => x.tag == "4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "1-1":

                        prefabToUse = prefabs.Find(x => x.tag == "1-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "2-1":
                        prefabToUse = prefabs.Find(x => x.tag == "2-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "3-1":
                        prefabToUse = prefabs.Find(x => x.tag == "3-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "4-1":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "1-2":
                        prefabToUse = prefabs.Find(x => x.tag == "1-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "2-2":
                        prefabToUse = prefabs.Find(x => x.tag == "2-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "3-2":
                        prefabToUse = prefabs.Find(x => x.tag == "3-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "4-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "4":

                switch (other.tag)
                {

                    case "1-1":

                        prefabToUse = prefabs.Find(x => x.tag == "1-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "2-1":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "3-1":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "4-1":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "1-2":
                        prefabToUse = prefabs.Find(x => x.tag == "1-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "2-2":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "3-2":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "4-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "1-3":
                        prefabToUse = prefabs.Find(x => x.tag == "1-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "2-3":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "3-3":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;
                    case "4-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "1-1":

                switch (other.tag)
                {

                    case "1-1":

                        prefabToUse = prefabs.Find(x => x.tag == "2-1");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-2":
                        prefabToUse = prefabs.Find(x => x.tag == "2-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-3":
                        prefabToUse = prefabs.Find(x => x.tag == "2-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-4":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "1-2":

                switch (other.tag)
                {

                    case "1-1":

                        prefabToUse = prefabs.Find(x => x.tag == "2-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-2":
                        prefabToUse = prefabs.Find(x => x.tag == "2-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-3":
                        prefabToUse = prefabs.Find(x => x.tag == "2-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-4":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "1-3":

                switch (other.tag)
                {

                    case "1-1":

                        prefabToUse = prefabs.Find(x => x.tag == "2-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-2":
                        prefabToUse = prefabs.Find(x => x.tag == "2-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-3":
                        prefabToUse = prefabs.Find(x => x.tag == "2-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-4":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "1-4":

                switch (other.tag)
                {

                    case "1-1":

                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-2":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-3":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "1-4":
                        prefabToUse = prefabs.Find(x => x.tag == "2-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "2-1":

                switch (other.tag)
                {

                    case "2-1":

                        prefabToUse = prefabs.Find(x => x.tag == "3-1");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-2":
                        prefabToUse = prefabs.Find(x => x.tag == "3-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-3":
                        prefabToUse = prefabs.Find(x => x.tag == "3-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-4":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "2-2":

                switch (other.tag)
                {

                    case "2-1":

                        prefabToUse = prefabs.Find(x => x.tag == "3-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-2":
                        prefabToUse = prefabs.Find(x => x.tag == "3-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-3":
                        prefabToUse = prefabs.Find(x => x.tag == "3-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-4":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "2-3":

                switch (other.tag)
                {

                    case "2-1":

                        prefabToUse = prefabs.Find(x => x.tag == "3-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-2":
                        prefabToUse = prefabs.Find(x => x.tag == "3-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-3":
                        prefabToUse = prefabs.Find(x => x.tag == "3-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-4":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "2-4":

                switch (other.tag)
                {

                    case "2-1":

                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-2":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-3":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "2-4":
                        prefabToUse = prefabs.Find(x => x.tag == "3-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "3-1":

                switch (other.tag)
                {

                    case "3-1":

                        prefabToUse = prefabs.Find(x => x.tag == "4-1");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-4":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "3-2":

                switch (other.tag)
                {

                    case "3-1":

                        prefabToUse = prefabs.Find(x => x.tag == "4-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-4":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "3-3":

                switch (other.tag)
                {

                    case "3-1":

                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-4":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "3-4":

                switch (other.tag)
                {

                    case "3-1":

                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "3-4":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                }
                break;
            case "4-1":

                switch (other.tag)
                {

                    case "4-1":

                        prefabToUse = prefabs.Find(x => x.tag == "4-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "4-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "4-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;



                }
                break;
            case "4-2":

                switch (other.tag)
                {

                    case "4-1":

                        prefabToUse = prefabs.Find(x => x.tag == "4-2");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "4-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "4-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;



                }
                break;
            case "4-3":

                switch (other.tag)
                {

                    case "4-1":

                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "4-2":
                        prefabToUse = prefabs.Find(x => x.tag == "4-3");
                        toMerge = other.gameObject;
                        coll = true;
                        break;

                    case "4-3":
                        prefabToUse = prefabs.Find(x => x.tag == "4-4");
                        toMerge = other.gameObject;
                        coll = true;
                        break;



                }
                break;







        }
    }
        void OnTriggerExit(Collider other)
    {
        //if(other.gameObject.tag == gameObject.tag)
        //{
            coll = false;
        //}
    }
    void Update()
    {
        if (enemyScript.lose)
        {
            Destroy(gameObject);
        }

        if (EndGame.endgame && playtime == 0)
        {
            
            playtime++;
            if(gameObject.tag != "1" && gameObject.tag != "2" && gameObject.tag != "3" && gameObject.tag != "4" )
            gameObject.transform.position = gameObject.transform.position + new Vector3(23f, -5.5f, -4f);
            gameObject.transform.Rotate(new Vector3(0, -30f, 0));
            moveToward = true;
            

        }
        if (moveToward)
        {
            if (counter < 1.5)
            {
                counter += Time.deltaTime;
            }
            if (counter > 1.4f)
            {

                Vector3 destination = new Vector3(gameObject.transform.position.x, colZone.transform.position.y, colZone.transform.position.z);
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, destination , 6f * Time.deltaTime);
            }
        }
        
      
        
    }
    void Start()
    {
        colZone = GameObject.Find("collisionZone");
    }
  private void OnMouseDown()
  {
      firstPos = gameObject.transform.position;
      firstScale = gameObject.transform.localScale;
        this.gameObject.transform.localScale *= 1.2f;
        this.gameObject.transform.position =
            new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
      RaycastHit hit;
      Physics.Raycast(transform.position, -transform.up, out hit);
      if (hit.collider.tag == "grid")
      {
          firstTale = hit.collider.gameObject;
      }

      firstPos = gameObject.transform.position;
    firstClickPos = Camera.main.WorldToScreenPoint(transform.position);
    offset = transform.position -
             Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, firstClickPos.z));
    Debug.Log("click");
    gameObject.layer = 0;
  }

   private void OnMouseDrag()
   {
     var curScreenSpace = new Vector3(Input.mousePosition.x,Input.mousePosition.y , firstClickPos.z);  
     var curPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;

     transform.position =  new Vector3(curPosition.x, transform.position.y, curPosition.z);
    
  
   
  
  }


   private void OnMouseUp()
   {

       this.gameObject.transform.localScale = firstScale;
       this.gameObject.transform.position =
           new Vector3(transform.position.x, transform.position.y - 0.3f, transform.position.z);
       RaycastHit hit1;
       Physics.Raycast(transform.position, -transform.up + new Vector3(0, 0, -0.1f), out hit1);

        if (coll)
        {
            Handheld.Vibrate();
            GameObject prefab2 = Instantiate(prefabToUse, toMerge.transform.position,
                    prefabToUse.transform.rotation);
            //  GameObject prefab2 = Instantiate(level2Prefab, toMerge.transform.position,
            //        level2Prefab.transform.rotation);
            //   firstTale.layer = 6;
            //hit.collider.gameObject.layer = 6; // ?
            if (mEffect != null) { GameObject mergeEffect = Instantiate(mEffect, toMerge.transform.position, mEffect.transform.rotation);  }
        
            if(mEffect2 != null) { GameObject mergeEffect2 = Instantiate(mEffect2, toMerge.transform.position, mEffect2.transform.rotation); }
            
            Destroy(toMerge);
            Destroy(gameObject);
        }

        else
        {

            if (hit1.collider.tag == "grid")
            {
                Debug.Log("hit to grid");
                if (hit1.collider.gameObject.layer == 6)
                {
                    Debug.Log("hey");
                    transform.position = hit1.collider.transform.position + new Vector3(0, 0.5f, 0);
                    hit1.collider.gameObject.layer = 0;
                    firstTale.layer = 6;

                }
                else
                {
                    OnNullResult();
                }
            }
            
                

             

            }
        }

    


   private void OnNullResult()
   {
       transform.position = firstPos;
       gameObject.layer = 7;
   }
}