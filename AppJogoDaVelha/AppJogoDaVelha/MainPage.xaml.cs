using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string Turn = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button ButtonClicked = (Button)sender;
            ButtonClicked.IsEnabled = false;

            if(Turn == "X")
            {
                ButtonClicked.Text = "X";
                Turn = "O";
            }
            else
            {
                ButtonClicked.Text = "O";
                Turn = "X";
            }
            if (Btn10.Text != "" &&
                Btn11.Text != "" &&
                Btn12.Text != "" &&
                Btn20.Text != "" &&
                Btn21.Text != "" &&
                Btn22.Text != "" &&
                Btn30.Text != "" &&
                Btn31.Text != "" &&
                Btn32.Text != "")
            {
                BtnReset.IsVisible = true;
            }
            //checar se o x ganhou
            //primeira linha
            if (Btn10.Text == "X" &&
               Btn11.Text == "X" &&
               Btn12.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }
            //segunda linha
            if (Btn20.Text == "X" &&
                Btn21.Text == "X" &&
                Btn22.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }
            //terceira linha
            if (Btn30.Text == "X" &&
                Btn31.Text == "X" &&
                Btn32.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }
            //primeira fileira
            if (Btn10.Text == "X" &&
                Btn20.Text == "X" &&
                Btn30.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }
            //segunda fileira
            if (Btn11.Text == "X" &&
                Btn21.Text == "X" &&
                Btn31.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }
            //terceira fileira
            if (Btn12.Text == "X" &&
                Btn22.Text == "X" &&
                Btn32.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }
            //diagonal pra direita
            if (Btn10.Text == "X" &&
                Btn21.Text == "X" &&
                Btn32.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }
            //diagonal pra esquerda
            if (Btn12.Text == "X" &&
                Btn21.Text == "X" &&
                Btn30.Text == "X")
            {
                DisplayAlert("Vitória!", "O X Ganhou!!!", "Ok");
                zerar();
            }

            //checar se o O ganhou
            //primeira linha
            if (Btn10.Text == "O" &&
               Btn11.Text == "O" &&
               Btn12.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }
            //segunda linha
            if (Btn20.Text == "O" &&
                Btn21.Text == "O" &&
                Btn22.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }
            //terceira linha
            if (Btn30.Text == "O" &&
                Btn31.Text == "O" &&
                Btn32.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }
            //primeira fileira
            if (Btn10.Text == "O" &&
                Btn20.Text == "O" &&
                Btn30.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }
            //segunda fileira
            if (Btn11.Text == "O" &&
                Btn21.Text == "O" &&
                Btn31.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }
            //terceira fileira
            if (Btn12.Text == "O" &&
                Btn22.Text == "O" &&
                Btn32.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }
            //diagonal pra direita
            if (Btn10.Text == "O" &&
                Btn21.Text == "O" &&
                Btn32.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }
            //diagonal pra esquerda
            if (Btn12.Text == "O" &&
                Btn21.Text == "O" &&
                Btn30.Text == "O")
            {
                DisplayAlert("Vitória!", "o O Ganhou!!!", "Ok");
                zerar();
            }

        }

        private void ButtonReset(object sender, EventArgs e)
        {
            Button ButtonReset = (Button)sender;
            ButtonReset.IsEnabled = false;


            zerar();
            BtnReset.IsVisible = false;
        }

        private void zerar()
        {
            Btn10.IsEnabled = true;
            Btn10.Text = "";
            Btn11.IsEnabled = true;
            Btn11.Text = "";
            Btn12.IsEnabled = true;
            Btn12.Text = "";

            Btn20.IsEnabled = true;
            Btn20.Text = "";
            Btn21.IsEnabled = true;
            Btn21.Text = "";
            Btn22.IsEnabled = true;
            Btn22.Text = "";

            Btn30.IsEnabled = true;
            Btn30.Text = "";
            Btn31.IsEnabled = true;
            Btn31.Text = "";
            Btn32.IsEnabled = true;
            Btn32.Text = "";

            BtnReset.IsEnabled = true;
        }
    }
}
