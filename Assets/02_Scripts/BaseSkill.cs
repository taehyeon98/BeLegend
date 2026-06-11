using System;
using UnityEngine;

public abstract class BaseSkill : MonoBehaviour
{
    protected string skillName;
    protected int skillCurrentLevel = 1;
    protected float skillDamaged;
    protected float skillCoolDown;
    protected float currentCoolDownTimer;
    protected float skillRange;
    protected Transform playerTransform;
    //UI에 스킬아이콘 사용할때
    [SerializeField] protected Sprite skillIcon;
    //UI에 스킬설명 띄울때 사용할곳.
    [SerializeField] protected string skillDescription;
    
    
    protected PlayerStat playerStat;

    protected virtual void Awake()
    {
        skillRange = 5f;
        skillDamaged = 5f;
        playerTransform = GameObject.FindWithTag("Player").transform;
        currentCoolDownTimer = 0;
        skillCurrentLevel = 1;
        Init(playerStat);
    }
    
    protected void Update()
    {
        currentCoolDownTimer += Time.deltaTime;
        if (currentCoolDownTimer >= skillCoolDown)
        {
            SkillUsing();
            currentCoolDownTimer = 0;
        }
    }

    protected virtual void Init(PlayerStat stat)
    {
        playerStat = stat;
        currentCoolDownTimer = 0;
    }

    protected virtual void SkillLevelUp()
    {
        skillCurrentLevel++;
        skillRange = skillCurrentLevel * skillRange;
        skillDamaged = skillCurrentLevel * skillDamaged;
    }
    protected abstract void SkillUsing();
}
