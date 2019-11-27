using MvvmCross.ViewModels;
using System.Threading.Tasks;
using QuadraticEquations.Core.Services;
using MvvmCross.Commands;
using System.Windows.Input;

namespace QuadraticEquations.Core.ViewModels
{
    public class QuadraticEquationViewModel : MvxViewModel
    {
        private readonly IQuadraticEquationService _calculationService;
        private double _a;
        private double _b;
        private double _c;
        private double _resultAdd;
        private double _resultSubtract;
        private MvxCommand _calculateCommand;

        public QuadraticEquationViewModel(IQuadraticEquationService calculationService)
        {
            _calculationService = calculationService;
        }

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }

        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }

        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double ResultAdd
        {
            get => _resultAdd;
            set => SetProperty(ref _resultAdd, value);
        }

        public double ResultSubtract
        {
            get => _resultSubtract;
            set => SetProperty(ref _resultSubtract, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        private void Calculate()
        {
            ResultAdd = _calculationService.GetEquadraticEquationAdd(A, B, C);
            ResultSubtract = _calculationService.GetEquadraticEquationSubtract(A, B, C);
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

    }
}
