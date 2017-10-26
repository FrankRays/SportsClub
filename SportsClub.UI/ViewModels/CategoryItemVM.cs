using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsClub.UI.Models;

namespace SportsClub.UI.ViewModels
{
    class CategoryItemVM : Common.ViewModel
    {
        private CategoryItem _model;

        public int ID => _model.ID;
        public string Name => _model.Name;
        public string Type => _model.Type;


    }
}
