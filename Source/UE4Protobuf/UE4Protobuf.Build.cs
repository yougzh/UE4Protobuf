// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class UE4Protobuf : ModuleRules
{
	public UE4Protobuf(ReadOnlyTargetRules Target) : base(Target)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Protobuf" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true

		// Protobuf source integrationg
		bEnableShadowVariableWarnings = false;
		bEnableUndefinedIdentifierWarnings = false;
		bEnableExceptions = true;

		if (Target.Platform == UnrealTargetPlatform.Win32 || Target.Platform == UnrealTargetPlatform.Win64)
        {
            Definitions.Add("_CRT_SECURE_NO_WARNINGS");
        }
    }
}
