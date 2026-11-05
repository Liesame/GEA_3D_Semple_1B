using UnityEngine;

public class StatPractice : MonoBehaviour
{

    public string playerName = "유저";
    public int level = 1;
    public float attack = 12.5f;
    public bool isBoss = false;

    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log("플레이어 이름 : " + playerName);
        Debug.Log("레벨 : " + level);
        Debug.Log("공격력 : " + attack);
        Debug.Log("보스 여부 : " + isBoss);
    }
}
