using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score = 0;
    public string name = "Player 1";
    public int health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            score = score + 1;
            print(score);
        }

        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            health = health - 1;
            print(health);
        }
    }
}
