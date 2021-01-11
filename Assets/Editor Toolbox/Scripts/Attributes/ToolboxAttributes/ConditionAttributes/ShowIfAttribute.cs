﻿using System;

namespace UnityEngine
{
    /// <summary>
    /// Shows property if provided condition is met. Conditional property has to be serialized.
    /// Supported condition types: <see cref="bool"/>, <see cref="int"/>, <see cref="float"/>, <see cref="double"/>, <see cref="string"/>, any <see cref="Enum"/>, and <see cref="Object"/> (but has to be compared to a <see cref="bool"/> value).
    /// Supported types: all.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ShowIfAttribute : ComparisonAttribute
    {
        public ShowIfAttribute(string propertyName, object valueToMatch) : base(propertyName, valueToMatch)
        { }
    }
}