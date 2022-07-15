using TowerDefense.Data;
using TowerDefense.ScriptableEvents;
using UnityEngine;

namespace TowerDefense.ScriptableEventsV2.ConcreteTypeEvents
{
    [CreateAssetMenu(menuName = "Create HealthEvent", fileName = "HealthEvent", order = 0)]
    public class HealthEvent : BaseGameEvent<Health>
    {
        public void Invoke(Health health) => Rise(health);
    }
}