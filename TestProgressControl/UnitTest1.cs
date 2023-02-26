using Avalonia.Controls;
using Avalonia.VisualTree;
using ProgressControl.Views;
using ProgressControl.Models;
using ProgressControl.ViewModels;
using System.Diagnostics;
using System.Drawing.Text;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace TestProgressControl
{

    public class UnitTest1
    {
        [Fact]
        public async void Test_1_AddButtonAndTextBox()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            Press_Add_Button();
            int TestCount = 1;
            Assert.Equal(Test_ListBox.ItemCount, TestCount); // TestAddButton + TextBox
            Press_Remove_Button();
        }
       [Fact]
        public async void Test_2_FirstComboBoxCheckAndYellowCheck()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FirstComboBox = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB1");
            FirstComboBox.SelectedIndex = 1;
            Press_Add_Button();
            await Task.Delay(30);
            var RealColor = mainWindow.GetVisualDescendants().OfType<Border>().First(b => b.Name == "Color1");
            var ExpColor = "Yellow";
            Assert.Equal(ExpColor, RealColor.Background.ToString());
            Press_Remove_Button();
            await Task.Delay(30);
        }
        [Fact]
        public async void Test_3_SecondComboBoxCheckAndGreenCheck()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FirstComboBox = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB2");
            FirstComboBox.SelectedIndex = 2;
            Press_Add_Button();
            await Task.Delay(30);
            var RealColor = mainWindow.GetVisualDescendants().OfType<Border>().First(b => b.Name == "Color2");
            var ExpColor = "Green";
            Assert.Equal(ExpColor, RealColor.Background.ToString());
            Press_Remove_Button();
            await Task.Delay(30);
        }
        [Fact]
        public async void Test_4_ThirdComboBoxCheckAndRedCheck()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FirstComboBox = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB3");
            FirstComboBox.SelectedIndex = 0;
            Press_Add_Button();
            await Task.Delay(30);
            var RealColor = mainWindow.GetVisualDescendants().OfType<Border>().First(b => b.Name == "Color3");
            var ExpColor = "Red";
            Assert.Equal(ExpColor, RealColor.Background.ToString());
            Press_Remove_Button();
            await Task.Delay(30);
        }
        [Fact]
        public async void Test_5_FourthComboBoxCheck()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FirstComboBox = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB4");
            FirstComboBox.SelectedIndex = 0;
            Press_Add_Button();
            await Task.Delay(30);
            var IndexBox = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "AddedCB4");
            Assert.Equal(FirstComboBox.SelectedIndex, IndexBox.SelectedIndex);
            Press_Remove_Button();
            await Task.Delay(30);
        }
        [Fact]
        public async void Test_6_FifthComboBoxCheck()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FirstComboBox = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB5");
            FirstComboBox.SelectedIndex = 2;
            Press_Add_Button();
            await Task.Delay(30);
            var IndexBox = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "AddedCB5");
            Assert.Equal(FirstComboBox.SelectedIndex, IndexBox.SelectedIndex);
            Press_Remove_Button();
            await Task.Delay(30);
        }
        [Fact]
        public async void Test_7_StudentAVGCheck()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB1");
            var CCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB2");
            var TCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB3");
            var FoCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB4");
            var FiCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB5");
            FCB.SelectedIndex = 1;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 2;
            FoCB.SelectedIndex = 0;
            FiCB.SelectedIndex = 1;
            Press_Add_Button();
            await Task.Delay(30);
            string ExpAVG = "1";
            var Avg = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(b => b.Name == "StudentAVG");
            Assert.Equal(ExpAVG, Avg.Text); //
            Press_Remove_Button();
            await Task.Delay(30);
        }
        [Fact]
        public async void Test_8_All_Sub_AVG_And_Color()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB1");
            var CCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB2");
            var TCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB3");
            var FoCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB4");
            var FiCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB5");
            FCB.SelectedIndex = 1;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 0;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 1;
            Press_Add_Button();
            await Task.Delay(30);
            Test_TextBox.Text = "Mileshko Anton Vladimirovich";
            FCB.SelectedIndex = 2;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 2;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 2;
            Press_Add_Button();
            await Task.Delay(30);
            Test_TextBox.Text = "Funtikov Ilya Olegovich";
            FCB.SelectedIndex = 0;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 0;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 0;
            Press_Add_Button();
            await Task.Delay(30);
            var SubAVG1 = mainWindow.GetSelfAndVisualDescendants().OfType<TextBlock>().First(b => b.Name == "SubAVG1");
            var SubAVG2 = mainWindow.GetSelfAndVisualDescendants().OfType<TextBlock>().First(b => b.Name == "SubAVG2");
            var SubAVG3 = mainWindow.GetSelfAndVisualDescendants().OfType<TextBlock>().First(b => b.Name == "SubAVG3");
            var SubAVG4 = mainWindow.GetSelfAndVisualDescendants().OfType<TextBlock>().First(b => b.Name == "SubAVG4");
            var SubAVG5 = mainWindow.GetSelfAndVisualDescendants().OfType<TextBlock>().First(b => b.Name == "SubAVG5");
            var SubColor1 = mainWindow.GetSelfAndVisualDescendants().OfType<Border>().First(b => b.Name == "SubC1");
            var SubColor2 = mainWindow.GetSelfAndVisualDescendants().OfType<Border>().First(b => b.Name == "SubC2");
            var SubColor3 = mainWindow.GetSelfAndVisualDescendants().OfType<Border>().First(b => b.Name == "SubC3");
            var SubColor4 = mainWindow.GetSelfAndVisualDescendants().OfType<Border>().First(b => b.Name == "SubC4");
            var SubColor5 = mainWindow.GetSelfAndVisualDescendants().OfType<Border>().First(b => b.Name == "SubC5");
            string ExpAVG1 = String.Format("{0:F2}", ((1 + 2 + 0) / 3));
            string ExpAVG2 = String.Format("{0:F2}", ((1 + 1 + 1) / 3));
            string ExpAVG3 = String.Format("{0:F2}", ((0.0 + 2.0 + 0.0) / 3.0));
            string ExpAVG4 = String.Format("{0:F2}", ((2 + 2 + 2) / 3));
            string ExpAVG5 = String.Format("{0:F2}", ((0.0 + 2.0 + 1.0) / 3.0));
            string ExpColor1 = "Yellow";
            string ExpColor2 = "Yellow";
            string ExpColor3 = "Red";
            string ExpColor4 = "Green";
            string ExpColor5 = "Yellow";
            Assert.Equal(SubAVG1.Text, ExpAVG1);
            Assert.Equal(SubAVG2.Text, ExpAVG2);
            Assert.Equal(SubAVG3.Text, ExpAVG3);
            Assert.Equal(SubAVG4.Text, ExpAVG4);
            Assert.Equal(SubAVG5.Text, ExpAVG5);
            Assert.Equal(SubColor1.Background.ToString(), ExpColor1);
            Assert.Equal(SubColor2.Background.ToString(), ExpColor2);
            Assert.Equal(SubColor3.Background.ToString(), ExpColor3);
            Assert.Equal(SubColor4.Background.ToString(), ExpColor4);
            Assert.Equal(SubColor5.Background.ToString(), ExpColor5);
            Press_Remove_Button();
            Press_Remove_Button();
            Press_Remove_Button();
        }
        [Fact]
        public async void Test_9_Remove_Button_Check()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            await Task.Delay(30);
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");

            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB1");
            var CCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB2");
            var TCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB3");
            var FoCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB4");
            var FiCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB5");
            FCB.SelectedIndex = 1;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 0;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 1;
            Press_Add_Button();
            await Task.Delay(30);
            Test_TextBox.Text = "Mileshko Anton Vladimirovich";
            FCB.SelectedIndex = 2;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 2;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 2;
            Press_Add_Button();
            await Task.Delay(30);
            Test_TextBox.Text = "Funtikov Ilya Olegovich";
            FCB.SelectedIndex = 0;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 0;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 0;
            Press_Add_Button();
            await Task.Delay(30);
            Press_Remove_Button();
            await Task.Delay(30);
            Press_Remove_Button();
            await Task.Delay(30);
            Assert.True(Test_ListBox.ItemCount == 1);
            Press_Remove_Button();
            await Task.Delay(30);
        }
        [Fact]
        public async void Test_10_Using_ComboBox_In_ListBox()
        {
            await Task.Delay(500);
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();
            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB1");
            var CCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB2");
            var TCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB3");
            var FoCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB4");
            var FiCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB5");
            FCB.SelectedIndex = 1;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 0;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 1;
            Press_Add_Button();
            var ActiualBorderBox1 = mainWindow.GetVisualDescendants().OfType<Border>().First(b => b.Name == "Color1");
            var ActiualComboBox1 = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "AddedCB1");
            var ActiualAVG = mainWindow.GetVisualDescendants().OfType<TextBlock>().First(b => b.Name == "StudentAVG");
            var ActiualAVGColor = mainWindow.GetVisualDescendants().OfType<Border>().First(b => b.Name == "Color6");
            ActiualComboBox1.SelectedIndex = 2;
            var ExpColor = "Green";
            Assert.Equal(ExpColor, ActiualBorderBox1.Background.ToString());
            var ExpAVG = String.Format("{0:F1}", (2.0 + 1.0 + 0.0 + 2.0 + 1.0) / 5.0);
            Assert.Equal(ExpAVG, ActiualAVG.Text);
            var ExpAVGColor = "Yellow";
            Assert.Equal(ExpAVGColor, ActiualAVGColor.Background.ToString());
            Press_Remove_Button();
        }
        [Fact]
        public async void Test_11_Check_Save_And_LoadButton()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>();
            Button Add_Button = button.First(b => b.Name == "AddButton");
            Button Remove_Button = button.First(b => b.Name == "RemoveButton");
            Button Save_Button = button.First(b => b.Name == "SaveButton");
            Button Load_Button = button.First(b => b.Name == "LoadButton");

            void Press_Add_Button() => Add_Button.Command.Execute(Add_Button.CommandParameter);
            void Press_Remove_Button() => Remove_Button.Command.Execute(Remove_Button.CommandParameter);
            void Press_Save_Button() => Save_Button.Command.Execute(Save_Button.CommandParameter);
            void Press_Load_Button() => Load_Button.Command.Execute(Load_Button.CommandParameter);

            var Test_ListBox = mainWindow.GetVisualDescendants().OfType<ListBox>().First(b => b.Name == "MyListBox");
            var Test_TextBox = mainWindow.GetVisualDescendants().OfType<TextBox>().First(b => b.Name == "MyTextBox");


            Test_TextBox.Text = "Pritula Alexey Dmitrievich";
            var FCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB1");
            var CCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB2");
            var TCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB3");
            var FoCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB4");
            var FiCB = mainWindow.GetVisualDescendants().OfType<ComboBox>().First(b => b.Name == "NewCB5");
            Press_Save_Button(); //Сохраняем пустой файл
            FCB.SelectedIndex = 1;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 0;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 1;
            Press_Add_Button();
            Test_TextBox.Text = "Mileshko Anton Vladimirovich";
            FCB.SelectedIndex = 2;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 2;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 2;
            Press_Add_Button();
            Test_TextBox.Text = "Funtikov Ilya Olegovich";
            FCB.SelectedIndex = 0;
            CCB.SelectedIndex = 1;
            TCB.SelectedIndex = 0;
            FoCB.SelectedIndex = 2;
            FiCB.SelectedIndex = 0;
            Press_Add_Button();
            ListBox TempListBox = Test_ListBox; //Сохраняем получившийся листбокс в отдельную переменную
            Press_Save_Button(); //Сохраняем трёх людей в файл
            Press_Remove_Button();
            Press_Remove_Button();
            Press_Remove_Button(); //Удаляем всех людей, делая наш листобкс пустым
            Press_Load_Button(); //загружаем листбокс из файла, и если сохранение и загрузка работают, то новый листбокс и листбокс в переменной должны быть одинаковыми
            ListBox NewListBox = Test_ListBox;
            Assert.Same(TempListBox, NewListBox);
            Press_Remove_Button();
            Press_Remove_Button();
            Press_Remove_Button();
            Press_Save_Button();
        }
    }
}