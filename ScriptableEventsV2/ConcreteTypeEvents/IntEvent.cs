
using Bricksloader.ScriptableEventsV2;
using UnityEngine;

namespace TowerDefense.ScriptableEventsV2.ConcreteTypeEvents
{
    [CreateAssetMenu(menuName = "Create IntEvent", fileName = "IntEvent", order = 0)]
    public class IntEvent : BaseGameEvent<int>
    {
        public void Invoke(int health) => Rise(health);
    }
}