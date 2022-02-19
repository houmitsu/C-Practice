using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int playerLives = 3;

        while(playerLives > 0)
        {
            Debug.Log("プレイヤーはまだ生きている");
            playerLives--;
        }

        Debug.Log("プレイヤーの命は尽きた");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
