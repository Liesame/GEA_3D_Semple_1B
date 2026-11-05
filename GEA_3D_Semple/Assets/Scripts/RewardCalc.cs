using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int member = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settie()
    {
        int sec = playSeconds % 60;
        int min = playSeconds / 60;
        int clock = min / 60;
        int playerGold = gold / member;
        int leaderGold = gold % member;
        int nomalExp = kills * expPerKill;
        int finalExp = (int)(nomalExp * expRate);
        int level = finalExp / 100;
        int anotherLevel = finalExp % 100;
        float averageDamage = (float)totalDamage / hits;

        Debug.Log(clock + "시간 " + (min % 60) + "분 " + sec + "초");
        Debug.Log("인당 골드: " + playerGold + ", 리더 보너스: " + leaderGold);
        Debug.Log("기본 경험치: " + nomalExp + ", 최종 경험치: " + finalExp);
        Debug.Log("레벨: " + (level + 1) + ", 남은 경험치" + (100 - anotherLevel));
        Debug.Log("평균 데미지: " + averageDamage);
    }
}
