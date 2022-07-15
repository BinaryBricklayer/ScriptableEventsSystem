using TowerDefense.Data;
using TowerDefense.ScriptableEvents;
using UnityEngine;

namespace TowerDefense.ScriptableEventsV2.ConcreteTypeEvents
{
    [CreateAssetMenu(menuName = "Create VoidEvent", fileName = "VoidEvent", order = 0)]
    public class VoidEvent : BaseGameEvent<Void>
    {
        public void Rise() => Rise(new Void());
    }
}