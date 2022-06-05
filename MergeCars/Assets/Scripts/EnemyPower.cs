using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class EnemyPower : MonoBehaviour
{
    public int enemyPower = 0;
    // Start is called before the first frame update
    private TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        text.text = enemyPower.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
