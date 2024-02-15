using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Operators
{
    public class CalViewModel : INotifyPropertyChanged
    {
        public CalViewModel()
        {
            AddCommand = new Command(() =>
            {
                Result = Add().ToString();

            });
            SubCommand = new Command(() =>
            {
                Result = Subtract().ToString();

            });
            MulCommand = new Command(() =>
            {
                Result = Multiply().ToString();

            });
            DivCommand = new Command(() =>
            {
                Result = Divide().ToString();

            });

        }
        private int _num1;
        private int _num2;
        private string _result;

        public int Num1
        {
            get => _num1;
            set
            {
                _num1 = value;
                OnPropertyChanged(nameof(Num1));
            }
        }

        public int Num2
        {
            get => _num2;
            set
            {
                _num2 = value;
                OnPropertyChanged(nameof(Num2));
            }
        }

        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public double Divide()
        {
            if (Num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)Num1 / Num2;
        }
        public Command AddCommand { get; }
        public Command SubCommand { get; }
        public Command MulCommand { get; }
        public Command DivCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

























