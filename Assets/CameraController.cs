using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // プレイヤーを宣言
    GameObject player;

    void Start()
    {
        // ネコをアタッチ
        this.player = GameObject.Find("cat_0");
    }

    void Update()
    {
        // プレイヤーの位置を取得
        Vector3 playerPos = this.player.transform.position;

        // カメラの位置をプレイヤーのY位置に合わせる
        transform.position = new Vector3(
            transform.position.x, playerPos.y, transform.position.z
        );
    }
}
