using UnityEngine;

namespace XIV.Packages.ScriptableObjects.Channels
{
    /// <summary>
    /// Channel for bool values.
    /// </summary>
    [CreateAssetMenu(menuName = MenuPaths.CHANNEL_BASE_MENU + nameof(BoolChannelSO))]
    public class BoolChannelSO : XIVChannelSO<bool>
    {
        
    }
}