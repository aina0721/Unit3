using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //毎フレーム力を加える
        rb.AddForce(player.transform.position - transform.position);
        //何もついてないtransform.positionは、アタッチされている
        //物体の座標になる
    }
}
