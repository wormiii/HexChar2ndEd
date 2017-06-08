using System.Windows;

namespace HexMain.Controls
{
    /// <summary>
    ///     Interaction logic for ItemWithPool.xaml
    /// </summary>
    public partial class ItemWithPool
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
            "Label", typeof(string), typeof(ItemWithPool), new PropertyMetadata(default(string)));

        public static readonly DependencyProperty CountProperty = DependencyProperty.Register(
            "Count", typeof(int), typeof(ItemWithPool), new PropertyMetadata(default(int)));

        public ItemWithPool()
        {
            InitializeComponent();
        }

        public string Label
        {
            get { return (string) GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        public int Count
        {
            get { return (int) GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }
    }
}