using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    public int gold = 100;

    [ContextMenu("골드 보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);
        int maxHp = hp;
        hp = 5;
        Debug.Log(maxHp);
    }

    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);
        byte red = 255;
        red++;
        Debug.Log(red);
    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;
        Debug.Log("합: " + a + b);
        Debug.Log("합: " + (a + b));
        Debug.Log(a + b + "점");
        Debug.Log("HP " + 7 / 2);
    }
}
