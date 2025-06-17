using System;

public struct EntityDisplayData
{
	public MapEntity entity;

	public EventExposer eventExposer;

	public MapEntityInteractionMutex interactionMutex;

	public Action<MapEntity> onConfirmStandardAction;

	public Action<MapEntity> onDismiss;

	public Action<MapEntity> onScanned;

	public Action<MapEntity> onForceDeleteEntity;
}
