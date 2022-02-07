using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnigCurve : MonoBehaviour
{
    public int currentAge = 30;
    public int addedAge = 1;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
    }

    /// <summary>
    /// 年齢の合計（整数）を計算する
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
