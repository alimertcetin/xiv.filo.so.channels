using System;
using UnityEngine;

namespace XIV.Packages.ScriptableObjects.Channels
{
    /// <summary>
    /// Parameterless action channel.
    /// </summary>
    [CreateAssetMenu(menuName = MenuPaths.CHANNEL_BASE_MENU + nameof(VoidChannelSO))]
    public class VoidChannelSO : ScriptableObject
    {
#if UNITY_EDITOR
        [SerializeField, TextArea] string description;
#endif
        Action action;

        public void Register(Action action) => this.action += action;
        public void Unregister(Action action) => this.action -= action;
        public void RaiseEvent() => action?.Invoke();
    }
}