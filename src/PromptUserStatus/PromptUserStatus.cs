using System;
using System.Linq;

using FrooxEngine;

using HarmonyLib;

using ResoniteModLoader;

namespace PromptUserStatus
{
	public sealed class PromptUserStatus : ResoniteMod
	{
		public const string VersionConstant = "1.0.0";

		public override string Name => "PromptUserStatus";

		public override string Author => "Dominion";

		public override string Version => VersionConstant;

		public override string Link => "https://github.com/Cyberboss/PromptUserStatus";

		[AutoRegisterConfigKey]
		private static readonly ModConfigurationKey<bool> Enabled = new ModConfigurationKey<bool>("Enabled", "Mod Enabled", () => true);

		private static ModConfiguration? Config;

		public override void OnEngineInit()
		{
			Config = GetConfiguration()!;
			Config.Save(true);
			Harmony harmony = new("net.dextraspace.PromptUserStatus");
			harmony.PatchAll();
		}
	}
};
