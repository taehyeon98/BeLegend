using Unity.VisualScripting;
using UnityEngine;

public class defaultSkill : BaseSkill
{
    protected override void Awake()
    {
        base.Awake();
        skillCoolDown = 0;
    }

    protected override void SkillUsing()
    {
        
    }
}