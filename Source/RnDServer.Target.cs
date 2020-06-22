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
        GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDIR=\"Spacewar\""); // ���� ������ �������̸�, �����̳� ��ȣ�� ���Ե��� �ʽ��ϴ�. �ݵ�� �������� �ʿ�� �����ϴ�.
        GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDESC=\"Cowboy: Dedicated Server\""); // Valve ������ ������Ʈ ��ü �̸����� ������ ���� �����մϴ�.
	}
}
