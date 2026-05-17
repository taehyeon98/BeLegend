using UnityEngine;


public abstract class BaseSkill : MonoBehaviour
{
    protected string skillName;
    protected int skillCurrentLevel = 1;
    protected int skillMaxLevel = 5;
    protected float skillDamaged;
    protected float skillCoolDown;
    protected float currentCoolDownTimer;
    protected float skillRange;
    [SerializeField] protected Sprite skillIcon;
    [TextArea]
    [SerializeField] protected string skillDescription;
    
    
    protected PlayerStat playerStat;

    protected virtual void Init(PlayerStat stat)
    {
        playerStat = stat;
    }

    protected abstract void SkillLevelUp();
}
