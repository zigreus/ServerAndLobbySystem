// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

#pragma once

#ifndef __RND_H__
#define __RND_H__

#include "EngineMinimal.h"
#include "Engine.h"
#include "UnrealNetwork.h"
#include "Online.h"

/*UENUM(BlueprintType)		//"BlueprintType" is essential to include
enum class EErrorMessageType : uint8
{
	EMT_ 	UMETA(DisplayName = "Dance"),
	VE_Rain 	UMETA(DisplayName = "Rain"),
	VE_Song		UMETA(DisplayName = "Song")
};*/

#endif

DECLARE_LOG_CATEGORY_EXTERN(RnD, Log, All);
#define RdLOG_CALLINFO (FString(__FUNCTION__) + TEXT("(") + FString::FromInt(__LINE__) + TEXT(")"))
#define RdLOG_S(Verbosity) UE_LOG(LogTemp, Verbosity, TEXT("%s"), *RdLOG_CALLINFO)
#define RdLOG(Verbosity, Format, ...) UE_LOG(LogTemp, Verbosity, TEXT("%s %s"), *RdLOG_CALLINFO, *FString::Printf(Format, ##__VA_ARGS__))

#define RdCHECK_AND_RETURN(Expr, ...)\
{\
	if (!(Expr))\
	{\
		RdLOG(Error, TEXT("ASSERTION: %s"), TEXT("'"#Expr"'"));\
		return __VA_ARGS__;\
	}\
}