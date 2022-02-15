using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningSwich : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string characterAction = "Attack";
        int diceRoll = 7;

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

        switch(diceRoll)
        {
            case 7:
            case 15:
                Debug.Log("中程度のダメージ。悪くないよ。");
                break;
            case 20:
                Debug.Log("急所に当たった。怪物が倒れるぞ");
                break;
            default:
                Debug.Log("的を外した君は、ばったり倒れた。");
                break;
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
