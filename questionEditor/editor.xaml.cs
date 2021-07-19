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
using System.Windows.Shapes;

namespace questionEditor
{
    /// <summary>
    /// Логика взаимодействия для editor.xaml
    /// </summary>
    public partial class editor : Window
    {
        question selectedQuestion;
        int selectedIndex = -1;
        public editor()
        {
            InitializeComponent();
        }
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int diff = comboBox.SelectedIndex + 1;
            string title = textQuestion.Text;
            string vari = textVariation.Text;
            int rezult = rbFalse.IsChecked == true ? 0 : 1;

            if (selectedQuestion == null)
            {
                question _question = new question();
                _question.typeOfDifficult = diff;
                _question.mTitle = title;
                _question.mAnswer = vari;
                _question.mRezult = rezult;
                _question._mRezult = (_question.mRezult == 0) ? "ложь" : "истина";
                CFileManager.appendQuestion(_question);
            }
            else
            {

                selectedQuestion.typeOfDifficult = diff;
                selectedQuestion.mTitle = title;
                selectedQuestion.mAnswer = vari;
                selectedQuestion.mRezult = rezult;
                selectedQuestion._mRezult = (selectedQuestion.mRezult == 0) ? "ложь" : "истина";
                CFileManager.updateQuestion(selectedIndex, selectedQuestion);
            }
            this.Close();
        }

        internal editor(int idx, question q)
        {
            selectedQuestion = q;
            selectedIndex = idx;
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (selectedQuestion == null)
            {
                comboBox.SelectedIndex = selectedIndex - 1;
            }
            else
            {
                comboBox.SelectedIndex = selectedQuestion.typeOfDifficult - 1;
                textQuestion.Text = selectedQuestion.mTitle;
                textVariation.Text = selectedQuestion.mAnswer;
                if (selectedQuestion.mRezult == 0)
                    rbFalse.IsChecked = true;
                else
                    rbTrue.IsChecked = true;
            }
        }
    }
}
