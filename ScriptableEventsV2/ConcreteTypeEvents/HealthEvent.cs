
using Bricksloader.ScriptableEventsV2;
using ScriptableEventsV2.CustomUnityEventComponent;
using UnityEngine;
namespace ScriptableEventsV2.ConcreteTypeEvents
{
    [CreateAssetMenu(menuName = "Create HealthEvent", fileName = "HealthEvent", order = 0)]
    public class HealthEvent : BaseGameEvent<Health>
    {
        public void Invoke(Health health) => Rise(health);
    }
}