// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SimpleGame : ModuleRules
{
	public SimpleGame(ReadOnlyTargetRules Target) : base(Target)
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
			"SimpleGame",
			"SimpleGame/Variant_Platforming",
			"SimpleGame/Variant_Platforming/Animation",
			"SimpleGame/Variant_Combat",
			"SimpleGame/Variant_Combat/AI",
			"SimpleGame/Variant_Combat/Animation",
			"SimpleGame/Variant_Combat/Gameplay",
			"SimpleGame/Variant_Combat/Interfaces",
			"SimpleGame/Variant_Combat/UI",
			"SimpleGame/Variant_SideScrolling",
			"SimpleGame/Variant_SideScrolling/AI",
			"SimpleGame/Variant_SideScrolling/Gameplay",
			"SimpleGame/Variant_SideScrolling/Interfaces",
			"SimpleGame/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
