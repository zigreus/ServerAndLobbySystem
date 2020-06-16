// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class RnD : ModuleRules
{
	public RnD(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        MinFilesUsingPrecompiledHeaderOverride = 1;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore",
            "UMG",
            "AIModule",
            "GameplayTasks", 
            "HeadMountedDisplay",
            "NavigationSystem",
            "OnlineSubsystem", // steam
            "OnlineSubsystemUtils", // steam
            "Networking" // steam
        });

        DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");

        // Uncomment if you are using Slate UI
        //PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

        //refresh your visual studio files from editor after adding this to avoid weird redline errors
        //linking steamworks
        if ((Target.Platform == UnrealTargetPlatform.Win64) || (Target.Platform == UnrealTargetPlatform.Win32) || (Target.Platform == UnrealTargetPlatform.Linux) || (Target.Platform == UnrealTargetPlatform.Mac))
        {
            PublicDependencyModuleNames.AddRange(new string[] { "Steamworks" });
        }
       // AddThirdPartyPrivateStaticDependencies(Target, "Steamworks");
       // PrivateDependencyModuleNames.Add("Steamworks");
        // Uncomment if you are using online features
        PrivateDependencyModuleNames.Add("OnlineSubsystem");
    }
}
