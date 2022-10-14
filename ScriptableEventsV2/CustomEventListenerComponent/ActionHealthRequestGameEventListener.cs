using Bricksloader.ScriptableEventsV2;
using ScriptableEventsV2.CustomUnityEventComponent;
using TowerDefense.ScriptableEventsV2.ConcreteTypeEvents;

namespace ScriptableEventsV2.CustomEventListenerComponent
{
    public class ActionHealthRequestGameEventListener : BaseGameEventListener<HealthAction, ActionEventHealthRequestEvent, UnityActionHealthRequestEvent>
    {
    }
}