﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="ComboBoxBase.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Controls;

namespace Chapter.Net.WPF.Controls.Bases
{
    /// <summary>
    ///     Base class for ComboBoxes.
    /// </summary>
    public class ComboBoxBase : ComboBox
    {
        /// <summary>
        ///     Create a new instance of ComboBoxBase.
        /// </summary>
        protected ComboBoxBase()
        {
            Loaded += OnLoaded;
            IsEnabledChanged += OnIsEnabledChanged;
        }

        /// <summary>
        ///     Callback when the control got loaded.
        /// </summary>
        /// <param name="sender">The loaded checkbox.</param>
        /// <param name="e">The loaded event parameter.</param>
        protected virtual void OnLoaded(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        ///     Callback when the control IsEnabled got changed.
        /// </summary>
        /// <param name="sender">The checkbox.</param>
        /// <param name="e">The IsEnabledChanged event parameter.</param>
        protected virtual void OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }
    }
}