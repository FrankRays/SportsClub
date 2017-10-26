using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsClub.UI.ViewModels;
using SportsClub.UI.Models;
using System.Collections.ObjectModel;

namespace SportsClub.UI.ViewModels
{
    class CategoriesVM : Common.ViewModel
    {
        private string _selectedCategory;
        private CategoryItemVM _selectedItem;
        
        public ObservableCollection<CategoryItemVM> Items { get; private set; }
        
        public string SelectedCategory
        {
            get => _selectedCategory;
            set
            {
                if (SetProperty(ref _selectedCategory, value))
                {
                    LoadNewItems();
                }
            }
        }
        public CategoryItemVM SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
            }
        }

        private void LoadNewItems()
        {
            Items.Clear();

            // Load new entities from db
        }
    }
}
