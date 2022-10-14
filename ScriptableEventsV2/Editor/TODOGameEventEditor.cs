
using UnityEngine;

namespace ScriptableEventsV2.Editor
{
    // [CustomEditor(typeof(BaseGameEvent<>),true )]
    public class HealthGameEventEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            RiseButton();
        }

        public void RiseButton()
        {
            if (GUILayout.Button("Test Event"))
            {
                //todo implement it
            }

        }
    }
}