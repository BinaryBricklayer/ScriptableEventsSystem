using TowerDefense.Data;
using TowerDefense.ScriptableEventsV2.ConcreteTypeEvents;
using TowerDefense.ScriptableEventsV2.CustomUnityEventComponent;

namespace TowerDefense.ScriptableEventsV2.CustomEventListenerComponent
{
    public class ActionHealthRequestGameEventListener : BaseGameEventListener<HealthAction, ActionEventHealthRequestEvent, UnityActionHealthRequestEvent>
    {
    }
}