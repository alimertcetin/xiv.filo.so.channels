using UnityEngine;

namespace XIV.Packages.ScriptableObjects.Channels
{
    /// <summary>
    /// Channel for int values.
    /// </summary>
    [CreateAssetMenu(menuName = MenuPaths.CHANNEL_BASE_MENU + nameof(IntChannelSO))]
    public class IntChannelSO : XIVChannelSO<int>
    {
        
    }
}