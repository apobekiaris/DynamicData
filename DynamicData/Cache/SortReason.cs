﻿// ReSharper disable once CheckNamespace
namespace DynamicData
{
    /// <summary>
    /// The reason why the sorted collection has changed
    /// </summary>
    public enum SortReason
    {
        /// <summary>
        /// The collection has loaded for the first time.
        /// </summary>
        InitialLoad,

        /// <summary>
        /// The comparer used to sort has changed 
        /// </summary>
        ComparerChanged,

        /// <summary>
        /// The data changed
        /// </summary>
        DataChanged,

        /// <summary>
        /// Sorting has been reapplied
        /// </summary>
        Reorder,

        /// <summary>
        /// A large number of changes has been received and the reset threshold has been exceeded.
        /// The entire set has been resorted without moves being calculated
        /// </summary>
        Reset
    }
}
