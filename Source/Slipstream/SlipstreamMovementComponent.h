// Slipstream - third-person movement sandbox.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/CharacterMovementComponent.h"
#include "SlipstreamMovementComponent.generated.h"

DECLARE_LOG_CATEGORY_EXTERN(LogSlipstreamMovement, Log, All);

/**
 *  Custom character movement for Slipstream.
 *  Owns all movement-ability behavior (Dash, Blink, Wall Climb, Recall).
 *  ASlipstreamCharacter handles input and forwards requests here.
 */
UCLASS()
class USlipstreamMovementComponent : public UCharacterMovementComponent
{
	GENERATED_BODY()

public:

	USlipstreamMovementComponent();

protected:

	virtual void BeginPlay() override;
};
