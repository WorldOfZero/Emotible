using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Graphics.Canvas.Effects;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Emotible
{
    public sealed partial class TextCopiedConfirmationControl : UserControl
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            nameof(Text), typeof(string), typeof(TextCopiedConfirmationControl), new PropertyMetadata(default(string)));

        public string Text
        {
            get { return (string) GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty BlurredBrushProperty = DependencyProperty.Register(
            nameof(BlurredBrush), typeof(CompositionEffectBrush), typeof(TextCopiedConfirmationControl), new PropertyMetadata(default(CompositionEffectBrush)));

        public CompositionEffectBrush BlurredBrush
        {
            get { return (CompositionEffectBrush) GetValue(BlurredBrushProperty); }
            set { SetValue(BlurredBrushProperty, value); }
        }

        public TextCopiedConfirmationControl()
        {
            this.InitializeComponent();
            InitializeBlurredBrush();
        }

        private void InitializeBlurredBrush()
        {
            var compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;
            GaussianBlurEffect blurEffect = new GaussianBlurEffect()
            {
                Name = "Blur",
                BlurAmount = 20.0f,
                BorderMode = EffectBorderMode.Hard,
                Optimization = EffectOptimization.Balanced,
                Source = new CompositionEffectSourceParameter("source")
            };
            var effectFactory = compositor.CreateEffectFactory(blurEffect, new[] { "Blur.BlurAmount" });
            var effectBrush = effectFactory.CreateBrush();
            effectBrush.SetSourceParameter("source", compositor.CreateBackdropBrush());
            BlurredBrush = effectBrush;
        }
    }
}
