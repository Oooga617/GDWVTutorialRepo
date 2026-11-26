// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CPlusPlus : ModuleRules
{
	public CPlusPlus(ReadOnlyTargetRules Target) : base(Target)
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
			"CPlusPlus",
			"CPlusPlus/Variant_Platforming",
			"CPlusPlus/Variant_Platforming/Animation",
			"CPlusPlus/Variant_Combat",
			"CPlusPlus/Variant_Combat/AI",
			"CPlusPlus/Variant_Combat/Animation",
			"CPlusPlus/Variant_Combat/Gameplay",
			"CPlusPlus/Variant_Combat/Interfaces",
			"CPlusPlus/Variant_Combat/UI",
			"CPlusPlus/Variant_SideScrolling",
			"CPlusPlus/Variant_SideScrolling/AI",
			"CPlusPlus/Variant_SideScrolling/Gameplay",
			"CPlusPlus/Variant_SideScrolling/Interfaces",
			"CPlusPlus/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
