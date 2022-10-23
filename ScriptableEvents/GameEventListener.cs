using System;
using TowerDefense.ScriptableEvents;
using UnityEngine;
using UnityEngine.Events;

namespace Bricksloader.ScriptableEvents
{
    [Serializable]
    public class GameEventListener :MonoBehaviour
    {
        [SerializeField] internal UnityEvent gameEventCallbacks;
        [SerializeField] private GameEvent gameEvent;

        private void OnEnable()=>
            Register();

        void Register()=>
            gameEvent.AddListener(this);
        
        private void OnDisable()=>
            gameEvent.RemoveListener(this);

        public void Invoke( )
        {
            gameEventCallbacks?.Invoke();
        }
    }
    
}