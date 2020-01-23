using EmpDeptSample.classes;
using EmpDeptSample.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EmpDeptSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public EmpDeptViewModel vm;// = new EmpDeptViewModel();
        public MainPage()
        {
            this.InitializeComponent();
        }

        public List<Location> ListofLocationsInsidePageClass { get; set; }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            EmpDeptViewModel obj = new EmpDeptViewModel();
            listview1.ItemsSource = obj.InstanceOfDepartmentData;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
              vm = new EmpDeptViewModel();

        ListofLocationsInsidePageClass = new List<Location>();
            ListofLocationsInsidePageClass.Add(new Location(1, "USA"));
            ListofLocationsInsidePageClass.Add(new Location(2, "Canada"));
            ListofLocationsInsidePageClass.Add(new Location(3, "UK"));
            ListofLocationsInsidePageClass.Add(new Location(4, "China"));
            ListofLocationsInsidePageClass.Add(new Location(5, "India"));

            //EmpDeptViewModel obj = new EmpDeptViewModel();
            //listview3.ItemsSource = obj.InstanceOfDepartmentData;

            this.Bindings.Update();
        }
    }
}
