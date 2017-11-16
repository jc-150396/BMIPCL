using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace bmiPCL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double h = double.Parse(height.Text);
            double w = double.Parse(weight.Text);

            if (h >= 3)
            {
                h /= 100;
            }

            double bmi = w / h / h;

            int intValue;

            if (bmi > 16.0)
            {
                if (bmi > 17.0)
                {
                    if (bmi > 18.5)
                    {
                        if (bmi > 25.0)
                        {
                            if (bmi > 30.0)
                            {
                                if (bmi > 35.0)
                                {
                                    if (bmi > 40.0)
                                    {
                                        intValue = 8;
                                    }
                                    else intValue = 7;
                                }
                                else intValue = 6;
                            }
                            else intValue = 5;
                        }
                        else intValue = 4;
                    }
                    else intValue = 3;
                }
                else intValue = 2;
            }
            else intValue = 1;

            switch (intValue)
            {
                case 1:
                    //DisplayAlert("BMI：" + bmi.ToString(), "16.00未満　痩せすぎ", "OK");
                    kekka.Text = "BMI：" + bmi.ToString()+ "16.00未満　痩せすぎ";
                    break;

                case 2:
                    //DisplayAlert("BMI：" + bmi.ToString(), "16～17未満　痩せ", "OK");
                    kekka.Text = "BMI：" + bmi.ToString() + "16～17未満　痩せ";
                    break;

                case 3:
                    //DisplayAlert("BMI：" + bmi.ToString(), "17～18.5未満	低体重(痩せぎみ)", "OK");
                    kekka.Text = "BMI：" + bmi.ToString() + "17～18.5未満	低体重(痩せぎみ)";
                    break;

                case 4:
                    //DisplayAlert("BMI：" + bmi.ToString(), "18.5～25未満　	普通体重", "OK");
                    kekka.Text = "BMI：" + bmi.ToString() + "18.5～25未満　	普通体重";
                    break;

                case 5:
                    //DisplayAlert("BMI：" + bmi.ToString(), "25～30未満	肥満(1度)", "OK");
                    kekka.Text = "BMI：" + bmi.ToString() + "25～30未満	肥満(1度)";
                    break;

                case 6:
                    //DisplayAlert("BMI：" + bmi.ToString(), "30～35未満	肥満(2度)", "OK");
                    kekka.Text = "BMI：" + bmi.ToString() + "30～35未満	肥満(2度)";
                    break;

                case 7:
                    //DisplayAlert("BMI：" + bmi.ToString(), "35～40未満	肥満(3度)", "OK");
                    kekka.Text = "BMI：" + bmi.ToString() + "35～40未満	肥満(3度)";
                    break;

                case 8:
                    //DisplayAlert("BMI：" + bmi.ToString(), "40以上	肥満(4度)", "OK");
                    kekka.Text = "BMI：" + bmi.ToString() + "40以上	肥満(4度)";
                    break;
            }
        }
    }
}
