using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnigCurve : MonoBehaviour
{
    //アクセス修飾子を変更
    private int currentAge = 30;

    public int addedAge = 1;

    public float pi = 3.14f;
    public string firstName = "Harrison";
    public bool isAuthor = true;

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        Debug.Log($"文字列には{firstName}のような変数を挿入できる");
        //Debug.Log(firstName * pi);
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
