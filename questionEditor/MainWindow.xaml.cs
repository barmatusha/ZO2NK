using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace questionEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int selectedDifficult = 1;
        List<question> listSelectedDifficult;
        public MainWindow()
        {
            InitializeComponent();
            
            listSelectedDifficult = new List<question>();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "QUIZ file(*.pbquiz)|*.pbquiz";
            if (openFileDialog.ShowDialog() == true)
                CFileManager.LoadFile(openFileDialog.FileName);
            else
            {
                MessageBox.Show("Не выбран файл с вопросами!", "QUIZ", MessageBoxButton.OK, MessageBoxImage.Information);
                System.Windows.Application.Current.Shutdown();
            }
        }

        void updateData(int type)
        {
            listSelectedDifficult.Clear();
            questionsList.ItemsSource = null;
            for (int i = 0; i < CFileManager.mFileData.Count; i++)
            {
                if (CFileManager.mFileData[i].typeOfDifficult == selectedDifficult)
                {
                    listSelectedDifficult.Add(CFileManager.mFileData[i]);
                }
            }

            questionsList.ItemsSource = listSelectedDifficult;
        }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedDifficult = ((TabControl)sender).SelectedIndex + 1;
            updateData(selectedDifficult);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            editor pEditor = new editor(selectedDifficult, null);
            if ((bool)pEditor.ShowDialog() == false)
            {
                this.Show();
                updateData(selectedDifficult);
            }
        }

        private void questionsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            editor pEditor = new editor(CFileManager.mFileData.IndexOf(listSelectedDifficult[questionsList.SelectedIndex]), listSelectedDifficult[questionsList.SelectedIndex]);
            if ((bool)pEditor.ShowDialog() == false)
            {
                this.Show();
                updateData(selectedDifficult);
                pEditor.Close();
                pEditor=null;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CFileManager.removeQuestion(listSelectedDifficult[questionsList.SelectedIndex]);
            updateData(selectedDifficult);
        }
    }
}
