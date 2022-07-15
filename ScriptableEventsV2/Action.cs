using System;
using TowerDefense.Data;

namespace Bricksloader.ScriptableEventsV2
{
    [System.Serializable]
    public struct HealthAction
    {
        public Action<Health> callback;
        public HealthAction(Action<Health> action) => callback = action;
    }
}