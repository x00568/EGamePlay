﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace EGamePlay.Combat.Ability
{
    public class PlayAnimationAbilityTask : AbilityTask
    {
        public override async Task ExecuteTaskAsync()
        {

            await Task.Delay(1000);
        }
    }
}