using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaningA: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        List<string> questPartyMembers = new List<string>()
        { "Grim the Barbarian", "Merlin the Wise", "Sterling the Knight"};

        questPartyMembers.Add("Craven the Necromancer");

        Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
