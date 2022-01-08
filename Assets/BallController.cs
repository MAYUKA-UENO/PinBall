using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見えるかもしれないz軸最小値
    public float visiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト
    public GameObject gameoverText;

    //ポイントを表示するテキスト
    public GameObject pointText;


    //ポイントの初期化
    int Score = 0;

    //Use this for initialization
    void Start()
    {
 
        //scene中のゲームオーバーテキスト取得
        this.gameoverText = GameObject.Find("GameOverText");

        //scene中のポイントテキスト取得
        this.pointText = GameObject.Find("PointText");

    }

    // 星や雲に当たった場合
    void OnCollisionEnter(Collision collision)
    {

        Debug.Log("ボールが当たったものはコレ→" + collision.gameObject.name);


        //ボールが小さい星SmallStarにあたった場合の加算
        if (collision.gameObject.name == "SmallStar")
        {
            Score += 2;
        }

        //ボールが小さい星SmallStarPrefab1にあたった場合の加算
        if (collision.gameObject.name == "SmallStarPrefab1")
        {
            Score += 2;
        }

        //ボールが小さい星SmallStarPrefab2にあたった場合の加算
        if (collision.gameObject.name == "SmallStarPrefab2")
        {
            Score += 2;
        }

        //ボールが小さい星SmallStarPrefab3にあたった場合の加算
        if (collision.gameObject.name == "SmallStarPrefab3")
        {
            Score += 2;
        }

        //ボールが大きい星LargeStarにあたった場合の加算
        if (collision.gameObject.name == "LargeStar")
        { 
            Score += 5;
        }

        //ボールが大きい星LargeStarPrefab1にあたった場合の加算
        if (collision.gameObject.name == "LargeStarPrefab1")
        {
            Score += 5;
        }

        //ボールが大きい星LargeStarPrefab2にあたった場合の加算
        if (collision.gameObject.name == "LargeStarPrefab2")
        {
            Score += 5;
        }

        //ボールが小さい雲SmallCloudにあたった場合の加算
        if (collision.gameObject.name == "SmallCloud")
        {
            Score += 10;
        }

        //ボールが小さい雲SmallCloudPrefabにあたった場合の加算
        if (collision.gameObject.name == "SmallCloudPrefab")
        {
            Score += 10;
        }

        //ボールが大きい雲LargeCloudにあたった場合の加算
        if (collision.gameObject.name == "LargeCloud")
        {
            Score += 20;
        }

        //得点表示
        pointText.GetComponent<Text>().text = Score + "";

    }

    // Update is called once per frame
    void Update()
    {

        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {

            //ゲームオーバー表示
            gameoverText.GetComponent<Text>().text = "Game Over";

        }

    }


}
