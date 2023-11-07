using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManager.Common.Model;
using EmployeeManager.Common.DataProvider;
using static System.Net.Mime.MediaTypeNames;
using Windows.System;

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

        public int Category
        {
            get => _reciept.Catagory;
            set
            {
                if (_reciept.Catagory != value)
                {
                    _reciept.Catagory = value;
                    RaisePropertChanged();
                }
            }
        }
        public bool VAT
        {
            get => _reciept.VAT;
            set
            {
                if (_reciept.VAT != value)
                {
                    _reciept.VAT = value;
                    RaisePropertChanged();
                }
            }
        }

        public double Total
        {
            get => _reciept.Total;
            set
            {
                if (_reciept.Total != value)
                {
                    _reciept.Total = value;
                    RaisePropertChanged();
                }
            }
        }
        public double VatValue
        {
            get => _reciept.VatValue;
            set
            {
                if (_reciept.VatValue != value)
                {
                    _reciept.VatValue = value;
                    RaisePropertChanged();
                }
            }
        }
        public string ScannedImage
        {
            get
            {
                if (_reciept.ScannedImage == null)
                {
                    _reciept.ScannedImage = "/Images/No_image_available.svg.png";
                }
                return _reciept.ScannedImage;
            }
            //get => _reciept.ScannedImage;
            set
            {
                if (_reciept.ScannedImage != value)
                {
                    _reciept.ScannedImage = value;
                    RaisePropertChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(Supplier);

        public void Save()
        {
            _recieptDataProvider.SaveReciept(_reciept);
        }

    }
}
