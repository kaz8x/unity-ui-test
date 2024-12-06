using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Player hrac;
    public Text text_score;
    public Text text_health;
    public Text text_name;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_score.text = hrac.score.ToString();
        text_health.text = hrac.health.ToString();
        text_name.text = hrac.name;
    }
}
