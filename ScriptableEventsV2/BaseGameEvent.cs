using System.Collections.Generic;
using UnityEngine;

namespace Bricksloader.ScriptableEventsV2
{
    public abstract class BaseGameEvent<T> : ScriptableObject
    {
        private List<IGameEventListener<T>> _listeners;
        private List<IGameEventListener<T>> Listeners => 
            _listeners ??= new ();

        public void AddListener(IGameEventListener<T> gameEventListener)
        {
            if (Listeners.Contains(gameEventListener)) return;
            Listeners.Add(gameEventListener);
        }


        public void RemoveListener(IGameEventListener<T> gameEventListener)
        {
            if (Listeners.Contains(gameEventListener)) return;
            Listeners.Remove(gameEventListener);
        }

        public void Rise(T args)
        {
            foreach (var listener in Listeners)
            {
                listener.Rise(args);
            }
        }
    }
}