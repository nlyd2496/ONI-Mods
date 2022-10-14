using System;
using HarmonyLib;
using PeterHan.PLib.Options;
using UnityEngine;
using TUNING;

namespace Run_Fast_跑快快
{
    public class Patches_b
    {
        //--------------------------------------------------------------------------------------------------
        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch("Initialize")]
        public class Patch_a
        {
            private static void Prefix()
            {
                DUPLICANTSTATS.MOVEMENT.NEUTRAL = (int)SingletonOptions<TestModSettings>.Instance.a1;//正常速度
                DUPLICANTSTATS.MOVEMENT.BONUS_1 = (int)SingletonOptions<TestModSettings>.Instance.a2;//一倍速
                DUPLICANTSTATS.MOVEMENT.BONUS_2 = (int)SingletonOptions<TestModSettings>.Instance.a3;//二倍速
                DUPLICANTSTATS.MOVEMENT.BONUS_3 = (int)SingletonOptions<TestModSettings>.Instance.a4;//三倍速
                DUPLICANTSTATS.MOVEMENT.BONUS_4 = (int)SingletonOptions<TestModSettings>.Instance.a5;//四倍速
            }
        }
        //--------------------------------------------------------------------------------------------------
    }
}
