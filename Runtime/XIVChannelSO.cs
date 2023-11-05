using System;
using UnityEngine;

namespace XIV.Packages.ScriptableObjects.Channels
{
    /// <summary>
    /// Base class for all channels.
    /// <example>
    /// <code>
    /// public struct Foo { public int bar; }
    /// 
    /// [CreateAssetMenu(menuName = "filePath" + nameof(Foo))]
    /// public class FooChannelSO : XIVChannelSO&lt;Foo&gt; { }
    ///
    /// public class MyClass : MonoBehaviour
    /// {
    ///     [SerializeField] FooChannelSO fooChannel;
    ///     Start() { fooChannel.RaiseEvent(new Foo { bar = 5 } ); }
    ///     OnEnable() { fooChannel.Register(OnFoo); }
    ///     OnDisable() { fooChannel.Unregister(OnFoo); }
    ///     void OnFoo(Foo f) { }
    /// }
    /// </code>
    /// </example>
    /// </summary>
    public abstract class XIVChannelSO<T> : ScriptableObject
    {
#if UNITY_EDITOR
        [SerializeField, TextArea] string description;
#endif
        Action<T> action;

        public void Register(Action<T> action) => this.action += action;
        public void Unregister(Action<T> action) => this.action -= action;
        public void RaiseEvent(T value) => action?.Invoke(value);
    }
}