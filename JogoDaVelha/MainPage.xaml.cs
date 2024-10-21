﻿using System;

namespace JogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int i = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verificando se o X ganhou
            // Linhas
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }

            //Diagonais X
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }

            // Colunas
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                await DisplayAlert("Parabéns!", "O X ganhou!", "OK, reiniciar");
                Zerar();
            }







            // Verificando se o O ganhou 
            // Linhas
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            //Diagonais O
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            // Colunas
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }

            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                await DisplayAlert("Parabéns!", "O ganhou!", "OK, reiniciar");
                Zerar();
            }




            if (btn10.Text != "" && btn11.Text != "" && btn12.Text != "" && btn20.Text != "" && btn21.Text != "" && btn22.Text != "" && btn30.Text != "" && btn31.Text != "" && btn32.Text != "")
            {
                if (i >= 9)
                {
                    await DisplayAlert("Aviso", "Deu Velha!", "Ok, reiniciar");
                    Zerar();
                }
            }
            i++;

        } // Fecha Método

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;


        }





    } // Fecha Classe
} // Fecha Namespace


