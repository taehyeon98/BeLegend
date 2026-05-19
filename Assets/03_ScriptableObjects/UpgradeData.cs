using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UpgradeData", menuName = "ScriptableObjects/UpgradeData", order = 0)]
public class UpgradeData : ScriptableObject
{
    public List<UpgradeDataClass> upgrades = new List<UpgradeDataClass>();
}

public class UpgradeDataClass
{
    public string UpgradeName;
    public int UpgradeLevel;
    public UpgradeType upgradeType;

    public int valuePerLevel = 5;
}

public enum UpgradeType
{
    PlayerHp,
    PlayerSpeed,
    PlayerAttackDamage,
    PlayerAttackSpeed,
    SkillDamage,
    SkillCoolDown,
    SkillRange
}