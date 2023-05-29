﻿using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace PetRenamer
{
	public class Config : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		public static Config Instance => ModContent.GetInstance<Config>();

		[DefaultValue(true)]
		public bool EnableChatAutofill;

		[ReloadRequired]
		[DefaultValue(true)]
		public bool ShowPetNameInSelectScreen;
	}
}
