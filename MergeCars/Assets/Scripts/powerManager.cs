using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class powerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int gridPower = 0;
   [SerializeField] private int enemyPower;
    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {

      if(gridPower > enemyPower)
        {
            text.color = Color.green;
        }
            text.text = gridPower.ToString();
        
    }
}
