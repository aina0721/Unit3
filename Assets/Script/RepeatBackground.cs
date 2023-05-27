using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPos;//リピートの開始位置
    float repeatWidth;//リピートの幅
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;//ゲームの開始時の場所を記憶
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        //背景のコライダーのx方向の長さの半分をリピート幅にする
        //【注意】これはStart内に書いているので、毎F変更とかはされない
        //ずっと固定！
    }

    // Update is called once per frame
    void Update()
    {
        //何か条件が満たされたら…
        if (startPos.x - transform.position.x > repeatWidth)
        {
            transform.position = startPos;//場所をリセット
        }
    }
}
