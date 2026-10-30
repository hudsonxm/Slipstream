// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Slipstream : ModuleRules
{
	public Slipstream(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Slipstream",
			"Slipstream/Variant_Platforming",
			"Slipstream/Variant_Platforming/Animation",
			"Slipstream/Variant_Combat",
			"Slipstream/Variant_Combat/AI",
			"Slipstream/Variant_Combat/Animation",
			"Slipstream/Variant_Combat/Gameplay",
			"Slipstream/Variant_Combat/Interfaces",
			"Slipstream/Variant_Combat/UI",
			"Slipstream/Variant_SideScrolling",
			"Slipstream/Variant_SideScrolling/AI",
			"Slipstream/Variant_SideScrolling/Gameplay",
			"Slipstream/Variant_SideScrolling/Interfaces",
			"Slipstream/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
