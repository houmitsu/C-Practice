using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningCurveFour : MonoBehaviour
{
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "Relic Stone";

    // Start is called before the first frame update
    void Start()
    {
        OpenTreasureChamber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenTreasureChamber()
    {
        if (pureOfHeart && rareItem == "Relic Stone")
        {
            if (!hasSecretIncantation)
            {
                Debug.Log("汝の心は清いが、知識が足りぬな");
            }
            else
            {
                Debug.Log("真の英雄よ、宝は汝のものだ！");
            }
        }
        else
        {
            Debug.Log("条件が揃ったら、また来るが良い");
        }
            
    }

}
