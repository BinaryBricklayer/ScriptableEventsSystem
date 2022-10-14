
using Bricksloader.ScriptableEventsV2;
using ScriptableEventsV2.ConcreteTypeEvents;
using ScriptableEventsV2.CustomUnityEventComponent;

namespace ScriptableEventsV2.CustomEventListenerComponent
{
    public class HealthGameEventListener : BaseGameEventListener<Health, HealthEvent, UnityHealthEvent>
    {
    }
}