using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerCondition condition;
    public PlayerController controller;

    public void Awake()
    {
        CharacterManager.Instance.Player = this; // CharacterManager �̱��� �ν��Ͻ��� Player �Ӽ��� ���� Player �ν��Ͻ��� ����
        controller = GetComponent<PlayerController>(); // ���� ���� ������Ʈ���� PlayerController ������Ʈ�� ������ controller ������ �Ҵ�
        condition = GetComponent<PlayerCondition>(); // ���� ���� ������Ʈ���� PlayerCondition ������Ʈ�� ������ condition ������ �Ҵ�
    }
}
