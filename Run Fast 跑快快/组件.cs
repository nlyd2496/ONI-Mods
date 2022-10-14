using System;
using HarmonyLib;
using KMod;
using PeterHan.PLib.Core;
using PeterHan.PLib.Options;

namespace Run_Fast_跑快快
{
	public class ModLoad : UserMod2
	{
		public override void OnLoad(Harmony harmony)
		{
			base.OnLoad(harmony);
			PUtil.InitLibrary(true);
			new POptions().RegisterOptions(this, typeof(TestModSettings));
		}
	}
}
