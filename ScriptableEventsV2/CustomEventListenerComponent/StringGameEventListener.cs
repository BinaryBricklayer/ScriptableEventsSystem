

using Bricksloader.ScriptableEventsV2;
using TowerDefense.ScriptableEventsV2.ConcreteTypeEvents;
using TowerDefense.ScriptableEventsV2.CustomUnityEventComponent;

namespace ScriptableEventsV2.CustomEventListenerComponent
{
    public class StringGameEventListener : BaseGameEventListener<string, StringEvent, UnityStringEvent>
    {
    }
}