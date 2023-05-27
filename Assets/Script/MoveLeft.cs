using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float speed = 30;//Groundが動く速さ
    PlayerController playerControllerScript;
    float leftBound = -15;//左の限界値
    //実は、PlayereControllerというのも、Rigidbodyとかと同様に「クラス」なので、型として宣言ができる！
    //使いい方はいつも同じで、<型名> 変数名 の順序
    //(例) Rigidbody rb;
    //(例) int score;
    //特にpublic等にしたい場合は、 (例) public int score;
    //などとするが、ふつうはpublicにしない。とにかく、<型名>＋変数名の順序！
    // Start is called before the first frame update
    void Start()
    {//private補われるが、あってもなくても同じ意味
       playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        //まず、左辺は頭で宣言しただけなので、実態が不明
        //そこで代入が必要。
        //PlayerControllerを持っているのはPlayer本人。なので、まず見つける(Find)する必要がある
        //それがGameObject.Findです。ただし、Findの引数には、「一字一句」同じ名前を入れる必要があります
        //なので、"Playe"とか誤字になるとバグります。
        //GameObject.Find("Player")がプレイヤー自信を表すと思いましょう。
        //そうすると、そいつがもっているPlayerControllerほしいですね。
        //それは、GetComponent<型名>()という方法で取ってこれます。
        //実際、みなさんはroll a ballをつくるときに、playerのRigidbodを取ってくるときに一回これを書いています。
    }

    // Update is called once per frame
    void Update()
    {
        //ゲームオーバー状態でなければ、backgroundを動かす
        if(playerControllerScript.gameOver == false) { 
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        //左の限界値(leftBound)よりも左に行ってしまったら…かつ、左行き過ぎたやつが障害物のタグ持ちなら
        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            //障害物は消してしまう
            Destroy(gameObject);
        }
    }
}
