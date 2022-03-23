using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double altura = double.Parse(txt_altura.Text);
            double peso = double.Parse(txt_peso.Text);

            double imc = peso / (altura * altura);


            if (imc < 18.5 && imc == 18.5) 
            {
                DisplayAlert("Seu IMC é menor que 18,5", "Você está abaixo do peso", "OK");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                DisplayAlert("Seu IMC está entre 18.5 e 24.9", "Você está no peso normal","OK");
            }
            else if (imc > 25 && imc <= 29.9)
            {
                DisplayAlert("Seu IMC está entre 25 e 29.9", "Você está com sobrepeso", "OK");
            }
            else if (imc > 30 && imc <= 34.9)
            {
                DisplayAlert("Seu IMC está entre 30 e 34.9", "Você está com obesidade Grau I", "OK");
            }
            else if (imc > 35 && imc <= 39.9) 
            {
                DisplayAlert("Seu IMC está entre 35 e 39.9", "Você está com obesidade Grau II", "OK");
            }
            else if (imc >= 40)
            {
                DisplayAlert("Seu IMC está maior ou igual a 40", "Você está com obesidade Grau III ou MÓRBIDA", "OK");
            }
        }
    }
}
