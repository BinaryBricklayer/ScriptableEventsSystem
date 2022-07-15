namespace TowerDefense.ScriptableEventsV2
{
    public interface IGameEventListener<T>
    {
        void Rise(T args);
    }
}