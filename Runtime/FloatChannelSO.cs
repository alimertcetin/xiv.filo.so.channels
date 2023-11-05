using UnityEngine;

namespace XIV.Packages.ScriptableObjects.Channels
{
    /// <summary>
    /// Channel for float values.
    /// </summary>
    [CreateAssetMenu(menuName = MenuPaths.CHANNEL_BASE_MENU + nameof(FloatChannelSO))]
    public class FloatChannelSO : XIVChannelSO<float>
    {
        
    }
}