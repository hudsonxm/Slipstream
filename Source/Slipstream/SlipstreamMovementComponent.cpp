// Slipstream - third-person movement sandbox.

#include "SlipstreamMovementComponent.h"

DEFINE_LOG_CATEGORY(LogSlipstreamMovement);

USlipstreamMovementComponent::USlipstreamMovementComponent()
{
	// Base walking/jumping tuning currently lives in ASlipstreamCharacter's constructor (template defaults).
	// Ability-specific tuning will be declared on this component.
}

void USlipstreamMovementComponent::BeginPlay()
{
	Super::BeginPlay();

	// Confirms the custom component replaced the default one. Safe to remove once abilities are in.
	UE_LOG(LogSlipstreamMovement, Log, TEXT("%s using %s"), *GetNameSafe(GetOwner()), *GetClass()->GetName());
}
