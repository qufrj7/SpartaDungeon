using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private static CharacterManager _instance; // 클래스 레벨에서 유일한 인스턴스를 저장하는 변수

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
    // 인스턴스를 생성하거나 반환하는 역할._instance가 없으면 새로운 GameObject를 생성하고, CharacterManager 컴포넌트를 추가

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
    // 게임 오브젝트가 파괴되지 않도록 하고, 중복 인스턴스를 방지

    // 동작 방식
    // Instance 프로퍼티: 이 프로퍼티를 통해 언제든지 CharacterManager의 인스턴스에 접근.
    // Awake 메서드: 게임 오브젝트가 파괴되지 않도록 하고, 중복 인스턴스를 방지.
}
