using UnityEngine;

namespace XIV.Packages.ScriptableObjects.Channels
{
    /// <summary>
    /// Channel for string values.
    /// </summary>
    [CreateAssetMenu(menuName = MenuPaths.CHANNEL_BASE_MENU + nameof(StringChannelSO))]
    public class StringChannelSO : XIVChannelSO<string>
    {
        
    }
}