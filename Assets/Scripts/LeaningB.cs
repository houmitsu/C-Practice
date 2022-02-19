using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningB : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5},
            {"Antidote", 8},
            {"Aspirin", 1}
        };

        foreach(KeyValuePair<string, int> kvp in itemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }


        //int numbberOfPotions = itemInventory["Potion"];
        //itemInventory["Potion"] = 10;
        //itemInventory.Add("Throwing Knife", 3);
        //itemInventory["Bandage"] = 5;

        //if(itemInventory.ContainsKey("Aspirin"))
        //{
        //    itemInventory["Aspirin"] = 3;
        //}

        //itemInventory.Remove("Antidote");

        //Debug.LogFormat("Item: {0}", itemInventory.Count);  
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
