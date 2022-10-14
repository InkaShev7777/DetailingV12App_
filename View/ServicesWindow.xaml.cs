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

namespace DetailingV12App.View
{
    /// <summary>
    /// Логика взаимодействия для ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {
        public ServicesWindow()
        {
            InitializeComponent();
        }
        private void AddSrvices()
        {
            for (int i = 0; i < 4; i++)
            {
                CustomControls.advtControl advt = new CustomControls.advtControl();
                advt.Width = 20;
                advt.Height = 20;
                //this.Content_
            }
        }
    }
}
