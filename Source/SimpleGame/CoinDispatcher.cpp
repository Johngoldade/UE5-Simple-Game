// Fill out your copyright notice in the Description page of Project Settings.


#include "CoinDispatcher.h"

// Sets default values
ACoinDispatcher::ACoinDispatcher()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ACoinDispatcher::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ACoinDispatcher::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

