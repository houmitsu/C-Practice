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
            {"Antidote", 8 },
            {"Aspirin", 1 }
        };

        Debug.LogFormat("Item: {0}", itemInventory.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
