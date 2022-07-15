The simple Way

How start with this?
1- clone this whatever you want
2- copy ScriptableEvents folder into your project
3- ITS ALL!


How its works?
1- create a folder to host you events
2- create a new event just RightClick-> Create ->GameEvent -> Create
3- define the name
4- ITS ALL!

How i rise that event?
1- wherever you want rise, add in code a reference like below
[code]
[SerializeField] private GameEvent _myEvent;
[/code]
2- wherever you need notify put the follow code
[code]
_myEvent.Rise();
[/code]
3- ITS ALL!

How i listen that event call?

1- Add the component GameEventListener to the listener GameObject in scene
2- Set the GameEvent in the inspector field
3- Set the Callback function in the UnityEvent field
4- ITS ALL!