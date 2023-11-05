using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.Common.Model;
using EmployeeManager.Common.DataProvider;

namespace EmployeeManager.ViewModel
{
    public partial class RecieptViewModel : ViewModelBase
    {
        private readonly Reciept _reciept;
        private readonly IRecieptDataProvider _recieptDataProvider;

        public RecieptViewModel(Reciept reciept, 
                                IRecieptDataProvider recieptDataProvider)
        {
            _reciept = reciept;
            _recieptDataProvider = recieptDataProvider;
        }

        public string Supplier
        {
            get => _reciept.Supplier;
            set
            {
                if (_reciept.Supplier != value)
                {
                    _reciept.Supplier = value;
                    RaisePropertChanged(nameof(Supplier));
                    RaisePropertChanged(nameof(CanSave));
                }
            }
        }

        public DateTimeOffset EntryDate
        {
            get => _reciept.EntryDate;
            set
            {
                if (_reciept.EntryDate != value)
                {
                    _reciept.EntryDate = value;
                    RaisePropertChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(Supplier);
    }
}
