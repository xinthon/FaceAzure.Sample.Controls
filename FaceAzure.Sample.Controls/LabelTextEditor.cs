using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FaceAzure.Sample.Controls
{
    public class LabelTextEditor : Control
    {
        public static DependencyProperty LabelStateProperty = DependencyProperty.Register("LabelState", typeof(State), typeof(LabelTextEditor), new PropertyMetadata(State.Normal));
        public static DependencyProperty ContentProperty = DependencyProperty.Register("Content", typeof(string), typeof(LabelTextEditor), new PropertyMetadata(string.Empty));

        public State LabelState
        {
            get => (State)GetValue(LabelStateProperty);
            set => SetValue(LabelStateProperty, value);
        }

        public string Content
        {
            get => (string)GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        static LabelTextEditor()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LabelTextEditor), new FrameworkPropertyMetadata(typeof(LabelTextEditor)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
        }

    }
    public enum State
    {
        Normal,
        Edit
    }
}
