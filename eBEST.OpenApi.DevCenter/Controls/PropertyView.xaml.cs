using eBEST.OpenApi.DevCenter.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace eBEST.OpenApi.DevCenter.Controls
{
    /// <summary>
    /// Interaction logic for PropertyView.xaml
    /// </summary>
    public partial class PropertyView : UserControl
    {
        public PropertyData? PropertyData
        {
            get { return (PropertyData?)GetValue(PropertyDataProperty); }
            set { SetValue(PropertyDataProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PropertyDataProperty =
            DependencyProperty.Register("PropertyData", typeof(PropertyData), typeof(PropertyView), new PropertyMetadata(null, PropertyDataPropertyChanged));

        private static void PropertyDataPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PropertyView self)
            {
                var newval = e.NewValue as PropertyData;
                if (newval != null)
                {
                    Binding myBinding = new Binding("HeaderText");
                    myBinding.Source = newval;
                    self.headerText.SetBinding(TextBlock.TextProperty, myBinding);
                    self.dataGrid.ItemsSource = newval.PropertyItems;
                }
            }
        }

        public ICommand? QueryCommand
        {
            get { return (ICommand?)GetValue(QueryCommandProperty); }
            set { SetValue(QueryCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for QueryCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QueryCommandProperty =
            DependencyProperty.Register("QueryCommand", typeof(ICommand), typeof(PropertyView), new PropertyMetadata(null, QueryCommandPropertyChanged));

        private static void QueryCommandPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PropertyView self)
            {
                self.queryButon.Command = e.NewValue as ICommand;
                self.queryButon.Visibility = Visibility.Visible;
            }
        }

        public ICommand? CellEditedCommand
        {
            get { return (ICommand?)GetValue(CellEditedCommandProperty); }
            set { SetValue(CellEditedCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for QueryCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CellEditedCommandProperty =
            DependencyProperty.Register("CellEditedCommand", typeof(ICommand), typeof(PropertyView), new PropertyMetadata(null));

        public ICommand? QueryNextCommand
        {
            get { return (ICommand?)GetValue(QueryNextCommandProperty); }
            set { SetValue(QueryNextCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for QueryCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty QueryNextCommandProperty =
            DependencyProperty.Register("QueryNextCommand", typeof(ICommand), typeof(PropertyView), new PropertyMetadata(null, QueryNextCommandPropertyChanged));

        private static void QueryNextCommandPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PropertyView self)
            {
                self.queryNextButon.Command = e.NewValue as ICommand;
                self.queryNextButon.Visibility = Visibility.Visible;
            }
        }

        public PropertyView()
        {
            InitializeComponent();
        }

        private void datagrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                var column = e.Column as DataGridBoundColumn;
                if (column != null && column.Header.Equals("Value"))
                {
                    CellEditedCommand?.Execute(e.Row.GetIndex());
                }
            }
        }
    }
}
