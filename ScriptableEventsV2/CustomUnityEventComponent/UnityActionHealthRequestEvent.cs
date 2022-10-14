using Bricksloader.ScriptableEventsV2;
using UnityEngine.Events;

namespace ScriptableEventsV2.CustomUnityEventComponent
{
    [System.Serializable]
    public class UnityActionHealthRequestEvent : UnityEvent<HealthAction>
    {
    }
}