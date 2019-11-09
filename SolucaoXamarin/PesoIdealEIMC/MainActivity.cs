using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

namespace PesoIdealEIMC
{
    [Activity(Label = "PesoIdealEIMC", MainLauncher = true)]
    public class MainActivity : Activity
    {
        Button btnCalcular;
        EditText edtAltura;
        EditText edtPeso;
        RadioGroup rdgSexo;
        RadioButton rdbMasculino;
        RadioButton rdbFeminino;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
            edtAltura = FindViewById<EditText>(Resource.Id.edtAltura);
            edtPeso = FindViewById<EditText>(Resource.Id.edtPeso);
            rdgSexo = FindViewById<RadioGroup>(Resource.Id.rdgSexo);
            rdbMasculino = FindViewById<RadioButton>(Resource.Id.rdbMasculino);
            rdbFeminino = FindViewById<RadioButton>(Resource.Id.rdbFeminino);

            btnCalcular.Click += btnCalcular_Click;
        }

        void btnCalcular_Click(Object sender, EventArgs e)
        {
            double IMC = 0;
            double pesoIdeal = 0;
            double altura = (double.Parse(edtAltura.Text))/100;

            if (rdbMasculino.Checked)
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }

            IMC = double.Parse(edtPeso.Text) / (altura * altura); 
            
            var intent = new Intent(this, typeof(Resultado));
            intent.PutExtra("IMC", IMC.ToString("0.00"));
            intent.PutExtra("PesoIdeal", pesoIdeal.ToString("0.00"));
            StartActivity(intent);
        }
    }
}

