using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace PesoIdealEIMC
{
    [Activity(Label = "PesoIdealEIMC")]
    public class Resultado : Activity
    {
        Button btnNovoIMC;
        TextView txtIMC;
        TextView txtPesoIdeal;
        TextView txtClassificacao;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.pgResultado);

            btnNovoIMC = FindViewById<Button>(Resource.Id.btnNovoIMC);
            txtIMC = FindViewById<TextView>(Resource.Id.txtIMC);
            txtPesoIdeal = FindViewById<TextView>(Resource.Id.txtPesoIdeal);
            txtClassificacao = FindViewById<TextView>(Resource.Id.txtClassificacao);

            txtIMC.Text = Intent.GetStringExtra ("IMC");
            txtPesoIdeal.Text = Intent.GetStringExtra("PesoIdeal");

            double classi = double.Parse(txtIMC.Text);

            if(classi < 18.5)
            {
                txtClassificacao.Text = "Abaixo do Peso";
                txtClassificacao.SetTextColor(Android.Graphics.Color.Red);
            }
            else
            {
                if (classi >= 18.5 && classi <= 24.9)
                {
                    txtClassificacao.Text = "Normal";
                    txtClassificacao.SetTextColor(Android.Graphics.Color.Green);
                }
                else
                {
                    if (classi >= 24.9 && classi <= 29.9)
                    {
                        txtClassificacao.Text = "Sobrepeso";
                        txtClassificacao.SetTextColor(Android.Graphics.Color.Yellow);
                    }
                    else
                    {
                        if (classi > 29.9)
                        {
                            txtClassificacao.Text = "Obeso";
                            txtClassificacao.SetTextColor(Android.Graphics.Color.Red);
                        }
                    }
                }
            }            

            btnNovoIMC.Click += btnNovoIMC_Click;
        }

        void btnNovoIMC_Click(Object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MainActivity));
            //intent.PutStringArrayListExtra("Lista", Lista);
            StartActivity(intent);
        }
    }
}