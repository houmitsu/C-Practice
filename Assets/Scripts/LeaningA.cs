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

        foreach(string partyMember in questPartyMembers)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        }


        //for (int i = 0; i < questPartyMembers.Count; i++)
        //{
        //    Debug.LogFormat("Index: {0} - {1}", i, questPartyMembers[i]);

        //    if (questPartyMembers[i] == "Merlin the Wise")
        //    {
        //        Debug.Log("君がいてくれて嬉しいよ、マーリン！");
        //    }

        //}


        //questPartyMembers.Add("Craven the Necromancer");

        //questPartyMembers.Insert(1, "Tanis the Thief");

        //questPartyMembers.RemoveAt(0);

        //Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
