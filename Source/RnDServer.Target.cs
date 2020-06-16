// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class RnDServerTarget : TargetRules
{
	public RnDServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		bUsesSteam = true;

		ExtraModuleNames.Add("RnD");
	}
}
