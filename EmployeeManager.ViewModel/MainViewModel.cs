using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System.Collections.ObjectModel;

namespace EmployeeManager.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private EmployeeViewModel _selectedEmployee;
        private RecieptViewModel _selectedReciept;
        private readonly IEmployeeDataProvider _employeeDataProvider;
        private readonly IRecieptDataProvider _recieptDataProvider;

        public MainViewModel(IEmployeeDataProvider employeeDataProvider
                            ,IRecieptDataProvider recieptDataProvider)
        {
            _employeeDataProvider = employeeDataProvider;
            _recieptDataProvider = recieptDataProvider;
        }

        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();
        public ObservableCollection<JobRole> JobRoles { get; } = new();
        public ObservableCollection<RecieptViewModel> Reciepts { get; } = new();
        public ObservableCollection<Category> Categories { get; } = new();

        public EmployeeViewModel SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                    RaisePropertChanged(); 
                    RaisePropertChanged(nameof(IsEmployeeSelected));
                }
            }
        }
        public RecieptViewModel SelectedReciept
        {
            get => _selectedReciept;
            set
            {
                if (_selectedReciept != value)
                {
                    _selectedReciept = value;
                    RaisePropertChanged();
                    RaisePropertChanged(nameof(IsRecieptSelected));
                }
            }
        }

        public bool IsEmployeeSelected => SelectedEmployee != null; 
        public bool IsRecieptSelected => SelectedReciept != null;

        public void Load()
        {
            LoadEmployees();
            LoadReciepts();
        }

        public void LoadEmployees()
        {
            var employees = _employeeDataProvider.LoadEmployees();
            var jobRoles  = _employeeDataProvider.LoadJobRoles();

            Employees.Clear();
            foreach (var employee in employees)
            {
                Employees.Add(new EmployeeViewModel(employee, _employeeDataProvider));
            }
            JobRoles.Clear();
            foreach (var jobRole in jobRoles)
            {
                JobRoles.Add(jobRole);
            }
        }
        public void LoadReciepts()
        {
            var reciepts = _recieptDataProvider.LoadReciepts();
            var categories = _recieptDataProvider.LoadCategories();

            Reciepts.Clear();
            foreach (var reciept in reciepts)
            {
                Reciepts.Add(new RecieptViewModel(reciept, _recieptDataProvider));
            }
            Categories.Clear();
            foreach (var category in categories)
            {
                Categories.Add(category);
            }
        }
    }
}
