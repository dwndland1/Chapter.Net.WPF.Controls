﻿// -----------------------------------------------------------------------------------------------------------------
// <copyright file="ChapterRepeatButton.cs" company="my-libraries">
//     Copyright (c) David Wendland. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------------------------------------------------

using System.ComponentModel;
using System.Windows;
using Chapter.Net.WPF.Controls.Bases;

// ReSharper disable once CheckNamespace

namespace Chapter.Net.WPF.Controls;

/// <summary>
///     A repeat button which brings additional features like a header, footer and icon.
/// </summary>
[TemplatePart(Name = "PART_Border", Type = typeof(FrameworkElement))]
public class ChapterRepeatButton : RepeatButtonBase
{
    /// <summary>
    ///     The ChapterRepeatButton style key.
    /// </summary>
    public static readonly ComponentResourceKey StyleKey = new(typeof(ChapterRepeatButton), "ChapterRepeatButton");

    /// <summary>
    ///     The Header dependency property.
    /// </summary>
    public static readonly DependencyProperty HeaderProperty =
        DependencyProperty.Register(nameof(Header), typeof(object), typeof(ChapterRepeatButton), new PropertyMetadata(null));

    /// <summary>
    ///     The Footer dependency property.
    /// </summary>
    public static readonly DependencyProperty FooterProperty =
        DependencyProperty.Register(nameof(Footer), typeof(object), typeof(ChapterRepeatButton), new PropertyMetadata(null));

    private FrameworkElement _border;

    static ChapterRepeatButton()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(ChapterRepeatButton), new FrameworkPropertyMetadata(typeof(ChapterRepeatButton)));
    }

    /// <summary>
    ///     Gets or sets the header.
    /// </summary>
    /// <value>Default: null.</value>
    [DefaultValue(null)]
    public object Header
    {
        get => GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }

    /// <summary>
    ///     Gets or sets the footer.
    /// </summary>
    /// <value>Default: null.</value>
    [DefaultValue(null)]
    public object Footer
    {
        get => GetValue(FooterProperty);
        set => SetValue(FooterProperty, value);
    }

    /// <inheritdoc />
    public override void OnApplyTemplate()
    {
        base.OnApplyTemplate();

        _border = GetTemplateChild("PART_Border") as FrameworkElement;
    }

    /// <inheritdoc />
    protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
    {
        base.OnRenderSizeChanged(sizeInfo);

        if (_border is { ActualHeight: > 0 })
            OvalCornerRadius = new CornerRadius(_border.ActualHeight / 2);
    }
}