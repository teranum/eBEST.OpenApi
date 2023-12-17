using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace eBEST.OpenApi.DevCenter.Models
{
    public partial class PropertyData : ObservableObject
    {
        [ObservableProperty]
        private string _HeaderText = string.Empty;

        public IList<PropertyItem> PropertyItems { get; } = new ObservableCollection<PropertyItem>();
    }
}
