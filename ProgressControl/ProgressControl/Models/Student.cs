using Avalonia.Media;
using DynamicData.Diagnostics;
using ProgressControl.ViewModels;
using ReactiveUI;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProgressControl.Models
{
    public class Student : ViewModelBase, INotifyPropertyChanged
    {
        public Student() { }
        private string studentFIO;
        public string StudentFIO { get => studentFIO; set => this.RaiseAndSetIfChanged(ref studentFIO, value); }
        private int firstPoint;
        public int FirstPoint { get => firstPoint; set { firstPoint = value;  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstPoint))); recalculate_avg(); } }       
        private int secondPoint;
        public int SecondPoint { get => secondPoint; set { this.RaiseAndSetIfChanged(ref secondPoint, value); recalculate_avg(); } }
        private int thirdPoint;
        public int ThirdPoint { get => thirdPoint; set { this.RaiseAndSetIfChanged(ref thirdPoint, value); recalculate_avg(); } }
        private int fourthPoint;
        public int FourthPoint { get => fourthPoint; set { this.RaiseAndSetIfChanged(ref fourthPoint, value); recalculate_avg(); } }
        private int fifthPoint;
        public int FifthPoint { get => fifthPoint; set { this.RaiseAndSetIfChanged(ref fifthPoint, value); recalculate_avg(); } }
        private string avgPoint = "";
        public string AvgPoint { get => avgPoint; set { avgPoint = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AvgPoint))); } }


        private string firstColor = "";
        public string FirstColor { get => firstColor; set { firstColor = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstColor))); } }

        private string secondColor = "";
        public string SecondColor { get => secondColor; set { secondColor = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SecondColor))); } } 

        private string thirdColor = "";
        public string ThirdColor { get => thirdColor; set { thirdColor = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ThirdColor))); } }

        private string fourthColor = "";
        public string FourthColor { get => fourthColor; set { fourthColor = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FourthColor))); } }

        private string fifthColor = "";
        public string FifthColor { get => fifthColor; set { fifthColor = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FifthColor))); } }

        private string avgColor = "";
        public string AvgColor { get => avgColor; set { avgColor = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AvgColor))); } }

        public event PropertyChangedEventHandler? PropertyChanged;
        public Student(string fio, int f1, int f2, int f3, int f4, int f5)
        {
            studentFIO= fio;
            firstPoint = f1;    
            secondPoint = f2;
            thirdPoint = f3;
            fourthPoint = f4;
            fifthPoint = f5;
            FirstColor = (f1 == 0 ? "Red" : (f1 == 1 ? "Yellow" : "Green"));
            SecondColor = (f2 == 0 ? "Red" : (f2 == 1 ? "Yellow" : "Green"));
            ThirdColor = (f3 == 0 ? "Red" : (f3 == 1 ? "Yellow" : "Green"));
            FourthColor = (f4 == 0 ? "Red" : (f4 == 1 ? "Yellow" : "Green"));
            FifthColor = (f5 == 0 ? "Red" : (f5 == 1 ? "Yellow" : "Green"));           
            AvgPoint = ((double)(firstPoint + secondPoint + thirdPoint + fourthPoint + fifthPoint) / (double)5).ToString();
            AvgColor = (double.Parse(AvgPoint) < 1 ? "Red" : (double.Parse(AvgPoint) > 1.5 ? "Green" : "Yellow"));
        }

        public void recalculate_avg()
        {
            AvgPoint = ((double)(firstPoint + secondPoint + thirdPoint + fourthPoint + fifthPoint) / (double)5).ToString();
            AvgColor = (double.Parse(AvgPoint) < 1 ? "Red" : (double.Parse(AvgPoint) > 1.5 ? "Green" : "Yellow"));
            FirstColor = (FirstPoint == 0 ? "Red" : (FirstPoint == 1 ? "Yellow" : "Green"));
            SecondColor = (SecondPoint == 0 ? "Red" : (SecondPoint == 1 ? "Yellow" : "Green"));
            ThirdColor = (ThirdPoint == 0 ? "Red" : (ThirdPoint == 1 ? "Yellow" : "Green"));
            FourthColor = (FourthPoint == 0 ? "Red" : (FourthPoint == 1 ? "Yellow" : "Green"));
            FifthColor = (FifthPoint == 0 ? "Red" : (FifthPoint == 1 ? "Yellow" : "Green"));
            var MainWindow = MainWindowViewModel.inst;
            if (MainWindow != null) MainWindow.Update();
        }
    }
}
