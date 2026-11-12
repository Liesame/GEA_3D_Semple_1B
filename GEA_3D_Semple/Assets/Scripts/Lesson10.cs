using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 0;
        bool hasSheield = true;
        bool isDead = hp <= 0;
        Debug.Log(isDead);
        Debug.Log(isDead && !hasSheield);
        Debug.Log(isDead || hasSheield);
        Debug.Log(!(hp > 0) == isDead);
    }

    [ContextMenu("쇼트 서킷")]

    void ShortCircuit()
    {
        int total = 100;
        int count = 0;
        if (count != 0 && total / count > 5)
        {
            Debug.Log("평균 5 초과");
        }
        if (count == 0 || total / count > 5)
        {
            Debug.Log("통과");
        }
        bool wrong = total / count > 5 && count != 0;

    }

    [ContextMenu("판단")]
    void Judge()
    {
        int hp = 20;
        int maxHp = 100;
        bool isStunned = false;
        bool hasPoison = false;

        bool canAttack = hp > 0 && !isStunned;
        bool isDanger = hp <= maxHp / 4 || hasPoison;
        Debug.Log(canAttack);
        Debug.Log(isDanger);
    }

    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 3;
        string result = "";

        for (int row = 1; row <= height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                result += "*";
            }
            result += "\n";
        }

        Debug.Log(result);
    }
}
