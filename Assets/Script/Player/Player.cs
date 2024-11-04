using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerCondition condition;
    public PlayerController controller;

    public void Awake()
    {
        CharacterManager.Instance.Player = this; // CharacterManager 싱글톤 인스턴스의 Player 속성에 현재 Player 인스턴스를 설정
        controller = GetComponent<PlayerController>(); // 현재 게임 오브젝트에서 PlayerController 컴포넌트를 가져와 controller 변수에 할당
        condition = GetComponent<PlayerCondition>(); // 현재 게임 오브젝트에서 PlayerCondition 컴포넌트를 가져와 condition 변수에 할당
    }
}
