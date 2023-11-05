using UnityEngine;

namespace XIV.Packages.ScriptableObjects.Channels
{
    /// <summary>
    /// Channel for Transform values.
    /// </summary>
    [CreateAssetMenu(menuName = MenuPaths.CHANNEL_BASE_MENU + nameof(TransformChannelSO))]
    public class TransformChannelSO : XIVChannelSO<Transform>
    {
        
    }
}