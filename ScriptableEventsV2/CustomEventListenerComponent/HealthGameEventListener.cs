using TowerDefense.Data;
using TowerDefense.ScriptableEventsV2.ConcreteTypeEvents;
using TowerDefense.ScriptableEventsV2.CustomUnityEventComponent;

namespace TowerDefense.ScriptableEventsV2.CustomEventListenerComponent
{
    public class HealthGameEventListener : BaseGameEventListener<Health, HealthEvent, UnityHealthEvent>
    {
    }
}