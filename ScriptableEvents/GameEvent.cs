using System.Collections.Generic;
using Bricksloader.ScriptableEvents;
using UnityEngine;

namespace TowerDefense.ScriptableEvents
{
    [CreateAssetMenu(   menuName = "GameEvent/Create", 
                        fileName = "New GameEvent", order = 0 )]
    public class GameEvent : ScriptableObject
    {
        [SerializeField]private List<GameEventListener> listeners;
        private List<GameEventListener> Listeners => 
            listeners ??= new ();

        internal void AddListener(GameEventListener gameEventListener)=>
            Listeners.Add(gameEventListener);
        
        internal void RemoveListener(GameEventListener gameEventListener)=>
            Listeners.Remove(gameEventListener);
        
        //this is called when the event raise
        internal void Rise()
        {
            foreach (var listener in Listeners)
                listener.Invoke();
        }
    }
}