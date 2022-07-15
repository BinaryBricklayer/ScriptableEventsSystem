using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace TowerDefense.ScriptableEventsV2
{
    //T- Type E-Event GEC-UnityEntityComponent
    public abstract class BaseGameEventListener<T, E, GEC> : MonoBehaviour,
        IGameEventListener<T> where E : BaseGameEvent<T> where GEC : UnityEvent<T>
    {
        [SerializeField] private E _gameEvent;
        [SerializeField] internal GEC gameEventCallbacks;

        public E GameEvent
        {
            get { return _gameEvent; }

            set { _gameEvent = value; }
        }

        private void OnEnable()
        {
            if(_gameEvent==null) return;
            GameEvent.AddListener(this);
        } 
        private void OnDisable()
        {
            if(_gameEvent==null) return;
            GameEvent.RemoveListener(this);
        }

        public void Rise(T args)
        {
            if(gameEventCallbacks == null) return;
            gameEventCallbacks.Invoke(args);
        }
    }
}