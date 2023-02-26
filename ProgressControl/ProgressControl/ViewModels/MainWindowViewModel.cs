using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using DynamicData;
using DynamicData.Kernel;
using ProgressControl.Models;
using ReactiveUI;
using System.Linq;
using Avalonia.Controls.Selection;
using System.IO;

namespace ProgressControl.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static MainWindowViewModel? inst;
        private ObservableCollection<Student> students = new ObservableCollection<Student>();
        private bool addEnable = false;
        public bool AddEnable
        {
            get => addEnable;
            set => this.RaiseAndSetIfChanged(ref addEnable, value);
        }
        public MainWindowViewModel()
        {
            /*Students = new ObservableCollection<Student> { new Student ("Опапий Папо Апопопович", 1, 2, 2,2, 2),
                                       new Student ("Сименс Василий Вячеславович", 0, 0, 0, 0, 0 ),
                                       new Student ( "Милешко Антон Владимирович", 0, 0, 0, 0, 0 ) };*/
            inst = this;
            //Add = ReactiveCommand.Create(() => new Student { StudentFIO = fio, FirstPoint = gr1, SecondPoint = gr2, ThirdPoint = gr3, FourthPoint = gr4, FifthPoint = gr5 });
            RemoveEnable = ((SelectedIndex >= 0 && SelectedIndex < students.Count()) ? true : false);
            Update();
        }
        public void AddStudent()
        {

            /*Observable.Merge(Add).Take(1).Subscribe(model =>
            {
                if (model != null)
                {
                    Students.Add(model);
                }
            });*/

            Students.Add(new Student(fio, int.Parse(gr1), int.Parse(gr2), int.Parse(gr3), int.Parse(gr4), int.Parse(gr5)));
            Update();
        }
        private bool removeEnable = false;
        public bool RemoveEnable
        {
            get => removeEnable;
            set => this.RaiseAndSetIfChanged(ref removeEnable, value);
        }
        public void RemoveStudent()
        {
            Students.RemoveAt(selectedIndex);
            Update();
        }
        private int selectedIndex;
        public int SelectedIndex
        {
            get => selectedIndex;
            set => this.RaiseAndSetIfChanged(ref selectedIndex, value);
            
        }
        /*private void Recalculate(object sender, RoutedEventArgs e)
        {
            var source = e.Source as Control;
            source.
            Students[selectedIndex].recalculate_avg();
        }*/
        private string fio;
        public string newFIO 
        { 
            get => fio;
            set
            {
                this.RaiseAndSetIfChanged(ref fio, value);
                if (newFIO == "") AddEnable = false;
                else AddEnable = true;
            }
        }
        private string gr1 = "0";
        public string GR1
        {
            get => gr1; 
            set => this.RaiseAndSetIfChanged(ref gr1, value);
        }

        private string gr2 = "0";
        public string GR2
        {
            get => gr2;
            set => this.RaiseAndSetIfChanged(ref gr2, value);
         
        }

        private string gr3 = "0";
        public string GR3
        {
            get => gr3;
            set => this.RaiseAndSetIfChanged(ref gr3, value);
        }

        private string gr4 = "0";
        public string GR4
        {
            get => gr4;
            set => this.RaiseAndSetIfChanged(ref gr4, value);
        }

        private string gr5 = "0";
        public string GR5
        {
            get => gr5;
            set => this.RaiseAndSetIfChanged(ref gr5, value);
        }
        public ObservableCollection<Student> Students
        {   
            get => students;
            set => this.RaiseAndSetIfChanged(ref students, value);
        }
        private string avg1 = "";
        public string Avg1
        {
            get => avg1;
            set => this.RaiseAndSetIfChanged(ref avg1, value);
        }
        private string avg2 = "";
        public string Avg2
        {
            get => avg2;
            set => this.RaiseAndSetIfChanged(ref avg2, value);
        }
        private string avg3 = "";
        public string Avg3
        {
            get => avg3;
            set => this.RaiseAndSetIfChanged(ref avg3, value);
        }
        private string avg4 = "";   
        public string Avg4
        {
            get => avg4;
            set => this.RaiseAndSetIfChanged(ref avg4, value);
        }
        private string avg5 = "";
        public string Avg5
        {
            get => avg5;
            set => this.RaiseAndSetIfChanged(ref avg5, value);
        }
        private string avg1color = "";
        public string Avg1color { get => avg1color; set => this.RaiseAndSetIfChanged(ref avg1color, value); }

        private string avg2color = "";
        public string Avg2color { get => avg2color; set => this.RaiseAndSetIfChanged(ref avg2color, value); }

        private string avg3color = "";
        public string Avg3color { get => avg3color; set => this.RaiseAndSetIfChanged(ref avg3color, value); }

        private string avg4color = "";
        public string Avg4color { get => avg4color; set => this.RaiseAndSetIfChanged(ref avg4color, value); }

        private string avg5color = "";
        public string Avg5color { get => avg5color; set => this.RaiseAndSetIfChanged(ref avg5color, value); }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void Update()
        {
            double a1 = 0.0, a2 = 0.0, a3 = 0.0, a4 = 0.0, a5 = 0.0;
            foreach(Student item in Students)
            {
                a1 += item.FirstPoint;
                a2 += item.SecondPoint;
                a3 += item.ThirdPoint;
                a4 += item.FourthPoint;
                a5 += item.FifthPoint;
            }
            int size = Students.Count();
            a1 /= size; a2 /= size; a3 /= size; a4 /= size; a5 /= size;
            Avg1color = (a1 < 1 ? "Red" : (a1 < 1.5 ? "Yellow" : "Green"));
            Avg2color = (a2 < 1 ? "Red" : (a2 < 1.5 ? "Yellow" : "Green"));
            Avg3color = (a3 < 1 ? "Red" : (a3 < 1.5 ? "Yellow" : "Green"));
            Avg4color = (a4 < 1 ? "Red" : (a4 < 1.5 ? "Yellow" : "Green"));
            Avg5color = (a5 < 1 ? "Red" : (a5 < 1.5 ? "Yellow" : "Green"));
            Avg1 = String.Format("{0:F2}",a1);
            Avg2 = String.Format("{0:F2}", a2);
            Avg3 = String.Format("{0:F2}", a3);
            Avg4 = String.Format("{0:F2}", a4);
            Avg5 = String.Format("{0:F2}", a5);
            RemoveEnable = ((SelectedIndex >= 0 && SelectedIndex < Students.Count()) ? true : false);
        }
        private bool canSave = false;
        public bool CanSave
        {
            get => canSave;
            set => this.RaiseAndSetIfChanged(ref canSave, value);
        }
        public void SaveFile()
        {
            using (FileStream fs = File.Create("../../../../studentfile.txt")) { }
            using (StreamWriter writer = new StreamWriter("../../../../studentfile.txt"))
            {
                foreach(Student item in Students)
                {
                    writer.Write(item.StudentFIO + "|" + item.FirstPoint + "|" + item.SecondPoint + "|" + item.ThirdPoint + "|" + item.FourthPoint + "|" + item.FifthPoint + "|" + item.AvgPoint + "\n");
                }
                writer.Write(Avg1 + "|" + Avg2 + "|" + Avg3 + "|" + Avg4 + "|" + Avg5 + "\n");
            }
            CanSave = true;
        }
        public void LoadFile()
        {
            List<string> rawstrings = new List<string>();
            using (StreamReader sr = File.OpenText("../../../../studentfile.txt"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    rawstrings.Add(s);
                }
            }
            string[] splitted;
            for (int line = 0; line < rawstrings.Count() - 1; line++)
            {
                splitted = rawstrings[line].Split("|");
                Students.Add(new Student(splitted[0], int.Parse(splitted[1]), int.Parse(splitted[2]), int.Parse(splitted[3]), int.Parse(splitted[4]), int.Parse(splitted[5])));
            }
            Update();
        }
        public ReactiveCommand<Unit, Student> Add { get; set; }
        public ReactiveCommand<Unit, Unit> Remove { get; }
    }
}
