using Bricksloader.ScriptableEventsV2;
using UnityEngine;

namespace TowerDefense.ScriptableEventsV2.ConcreteTypeEvents
{
    [CreateAssetMenu(menuName = "Create StringEvent", fileName = "StringEvent", order = 0)]
    public class StringEvent : BaseGameEvent<string>
    {
        public void Invoke(string health) => Rise(health);
    }
}