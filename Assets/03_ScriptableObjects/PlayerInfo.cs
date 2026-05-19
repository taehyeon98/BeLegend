using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInfo", menuName = "ScriptableObjects/PlayerInfo", order = 0)]
public class PlayerInfo : ScriptableObject
{
    public float basePlayerHp = 100f;
    public float basePlayerSpeed = 5f;
    public float basePlayerAttackSpeed = 1f;
    public float basePlayerAttackDamage = 10f;
    public float defualtNeedExp = 100f;
    public float expMag = 1.5f;
}
