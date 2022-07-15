using TowerDefense.Data;
using TowerDefense.ScriptableEvents;
using UnityEngine;

namespace TowerDefense.ScriptableEventsV2.ConcreteTypeEvents
{
    [CreateAssetMenu(menuName = "Create ActionEventHealthRequest", fileName = "ActionEventHealthRequest", order = 0)]
    public class ActionEventHealthRequestEvent : BaseGameEvent<HealthAction>
    {
        public void Invoke(HealthAction healthAction) => Rise(healthAction);
    }
}