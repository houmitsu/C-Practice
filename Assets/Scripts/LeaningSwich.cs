using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningSwich : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string characterAction = "Attack";

        switch(characterAction)
        { 
            case "Heal":
                Debug.Log("薬を送ったぞ");
                break;
            case "Attack":
                Debug.Log("闘え");
                break;
            default:
                Debug.Log("防御せよ");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
