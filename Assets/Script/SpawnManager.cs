using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //面倒なのでprivateは省略してます
    [SerializeField] GameObject obstaclePrefab;//障害物プレハブ
    Vector3 spawnPos = new Vector3(25,0,0);//スポーンする場所
    float elapssedTime;//経過時間
    // Start is called before the first frame update
    void Update()
    {
        elapssedTime += Time.deltaTime;//毎Fの時間を足していく
        //経過時間が2秒を超えたら
        if(elapssedTime > 2.0f)
        {
            Instantiate(obstaclePrefab, spawnPos, transform.rotation);
            elapssedTime = 0.0f;//経過時間リセット
        } 
    }

    // Update is called once per frame
}
