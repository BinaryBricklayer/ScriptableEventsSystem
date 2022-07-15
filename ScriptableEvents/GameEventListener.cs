using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace TowerDefense.ScriptableEvents
{
    [Serializable]
    public class GameEventListener :MonoBehaviour
    {
        [SerializeField] internal UnityEvent gameEventCallbacks;
        [SerializeField] private GameEvent gameEvent;

        private void Awake()=>
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