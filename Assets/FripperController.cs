using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    // HingeJointコンポーネント
    private HingeJoint myHingeJoint;

    //初期
    private float defaultAngle = 20;
    //弾いたとき
    private float flickAngle = -20;

    //use this for いにしゃ〜
    void Start()
    {
        //HingeJointコンポ取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        //フリッパーの傾き
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {

        //Aキーで左フリッパー動かす
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) )&& tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //Dキーで右フリッパー動かす
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S)) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }


        //キー離すとフリッパー戻る
        if ((Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S)) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if ((Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.S)) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

    }

    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {

        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;

    }
    
}
