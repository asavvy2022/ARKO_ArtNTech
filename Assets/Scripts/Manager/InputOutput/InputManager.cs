using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Consts;

public class InputManager : SingleTone<InputManager>
{
    Player player;
    Dictionary<KeyCode, System.Action> inputDic;

    Vector2 parryVector;

    bool parryFlag = false;
    protected override void Init()
    {
        base.Init();
        inputDic = new Dictionary<KeyCode, System.Action>{
            {KeyCode.W, GetKey_W},
            {KeyCode.A, GetKey_A},
            {KeyCode.S, GetKey_S},
            {KeyCode.D, GetKey_D},
        };

        GameObject inputCanvas = GameObject.Find("InputCanvas");
    }

    void Update()
    {
        JoyStickInput();
        if(Input.anyKey)
            foreach(KeyCode key in inputDic.Keys)
                if(Input.GetKey(key))
                    inputDic[key]();
        if(Input.GetKeyDown(KeyCode.Space))
            GetKeyDown_Space();
        if(Input.GetKeyUp(KeyCode.Space))
            GetKeyUp_Space();

        if(Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    void JoyStickInput(){
    }
    
    void GetKey_W(){

    }

    void GetKey_A(){
       
    }

    void GetKey_S(){

    }

    void GetKey_D(){
        
    }

    void GetKeyDown_Space()
    {
        parryFlag = true;
    }

    void GetKeyUp_Space()
    {
       
    }

    void GetKey_Attack(){

    }
}
