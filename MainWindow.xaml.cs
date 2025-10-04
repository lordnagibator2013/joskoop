using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lord13;

public partial class MainWindow : Window
{
    int count = 0;
    string[] listbox = new string[50];

    private void NeGotovo()
    {
        MessageBox.Show("не готово(");
    }

    private void Error()
    {
        MessageBox.Show("ты дурачина");
    }

    private void AddTask(object sender, RoutedEventArgs e)
    {
        if (Textbox.Text != "" && count != listbox.Length)
        {
            string vvod = Textbox.Text;
            Textbox.Text = "";
            listbox[count] = vvod;
            count++;
            UpdateListbox();
        }
        else
        {
            Error();
        }
    }

    private void RemoveTask(object sender, RoutedEventArgs e)
    {
        string selectS = Listbox.SelectedItem as string;
        if (selectS != null)
        {
            int selectI = Listbox.SelectedIndex;
            List<string> tempList = listbox.ToList();
            tempList.RemoveAt(selectI);
            listbox = tempList.ToArray();
            UpdateListbox();
        }
        else
        {
            Error();
        }
    }

    private void ChangeTask(object sender, RoutedEventArgs e)
    {
        string vvod = Textbox.Text;
        if (vvod != null && vvod != "" && Listbox.SelectedItem != null)
        {
            Textbox.Text = "";
            int selectI = Listbox.SelectedIndex;
            listbox[selectI] = vvod;
            UpdateListbox();
        }
        else
        {
            Error();
        }
    }

    private void Exit(object sender, RoutedEventArgs e)
    {
        Environment.Exit(0);
    }

    private void UpdateListbox()
    {
    Listbox.Items.Clear();
    foreach (string item in listbox)
    {
        Listbox.Items.Add(item);
    }
}
    public MainWindow()
    {
        InitializeComponent();
    }
}