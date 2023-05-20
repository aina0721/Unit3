using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //privateは省略可能
    Rigidbody rb;
    [SerializeField] float gravityModifier;//重力値調整用
    [SerializeField] float jumpForce;//ジャンプ力
    [SerializeField] bool isOnGround;//地面についているか
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //スペースキーが押されたて、かつ、地面にいたら
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) { 
            //上へ力を加える
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isOnGround = false;//ジャンプした＝地面にいない
        }
    }
    //衝突が起きたら実行
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { 
        isOnGround = true;//地面についている状態に変更
        }
    }
}
