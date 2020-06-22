// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class RnDServerTarget : TargetRules
{
	public RnDServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
        bUsesSteam = true;

        ExtraModuleNames.Add("RnD");

        GlobalDefinitions.Add("UE4_PROJECT_STEAMSHIPPINGID=480");
        GlobalDefinitions.Add("UE4_PROJECT_STEAMPRODUCTNAME=\"Spacewar\"");
        GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDIR=\"Spacewar\""); // 보통 게임의 폴더명이며, 공백이나 기호는 포함되지 않습니다. 반드시 폴더명일 필요는 없습니다.
        GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDESC=\"Cowboy: Dedicated Server\""); // Valve 에서는 프로젝트 전체 이름으로 설정할 것을 권장합니다.
	}
}
