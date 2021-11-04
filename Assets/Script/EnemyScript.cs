using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    CharacterController Controller;
    Transform Target;
    GameObject Player;

    [SerializeField]
    float MoveSpeed = 2.0f;
    int DetecDist = 15;
    bool InArea = false;

    // Use this for initialization
    void Start()
    {
        //プレイヤータグの取得
        Player = GameObject.FindWithTag("Player");
        Target = Player.transform;

        Controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InArea)
        {
            //プレイヤーのほうに向かせる
            this.transform.LookAt(Target.transform);

            //球とプレイヤー間の距離を計算
            Vector3 direction = Target.position - this.transform.position;
            direction = direction.normalized;

            //プレイヤー方向の速度を作成
            Vector3 velocity = direction * MoveSpeed;

            //プレイヤーがジャンプしたときに球が浮かないようにy速度を0にしておく
            velocity.y = 0.0f;

            //球を動かす
            Controller.Move(velocity * Time.deltaTime);
        }
        //プレイヤーと球間の距離を計算
        Vector3 Apos = this.transform.position;
        Vector3 Bpos = Target.transform.position;
        float distance = Vector3.Distance(Apos, Bpos);

        //距離がDetecDistの設定値未満の場合は検知フラグをfalseにする。
        if (distance > DetecDist)
        {
            InArea = false;
        }

    }

    //プレイヤーが検知エリアに入ったら検知フラグをtrueにする。
    private void OnTriggerEnter(Collider other)
    {
        InArea = true;
    }

}
