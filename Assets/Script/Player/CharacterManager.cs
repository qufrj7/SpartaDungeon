using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance; // Ŭ���� �������� ������ �ν��Ͻ��� �����ϴ� ����

    public static CharacterManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject("CharacterManager").AddComponent<CharacterManager>();
            }
            return _instance;
        }
    }
    // �ν��Ͻ��� �����ϰų� ��ȯ�ϴ� ����._instance�� ������ ���ο� GameObject�� �����ϰ�, CharacterManager ������Ʈ�� �߰�

    public Player _player;
    public Player Player
    {
        get { return _player; }
        set { _player = value; }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            if (_instance == this)
            {
                Destroy(gameObject);
            }
        }

    }
    // ���� ������Ʈ�� �ı����� �ʵ��� �ϰ�, �ߺ� �ν��Ͻ��� ����

    // ���� ���
    // Instance ������Ƽ: �� ������Ƽ�� ���� �������� CharacterManager�� �ν��Ͻ��� ����.
    // Awake �޼���: ���� ������Ʈ�� �ı����� �ʵ��� �ϰ�, �ߺ� �ν��Ͻ��� ����.
}
