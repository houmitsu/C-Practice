using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnigCurve : MonoBehaviour
{
    public int addedAge = 1;

    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 32;
        GenerateCharacter("Spike", characterLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);
    }
}
