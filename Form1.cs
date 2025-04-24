using ReflectionHomework.Classes;
using ReflectionHomework.Interfaces;
using System.Reflection;

namespace ReflectionHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxOdemeYontemleri_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<Type> odemeSiniflari = new List<Type>();
           

            Type interfaceTipi = typeof(IOdeme);
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsClass && interfaceTipi.IsAssignableFrom(type) && !type.IsAbstract && !type.IsInterface)
                {
                    comboBoxOdemeYontemleri.Items.Add(type.Name);
                }
            }
        }

        private void buttonOdemeYap_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tutar = Convert.ToDecimal(textBox1.Text); //Kullan�c�n�n girdi�i tutar� textboxtan al�yoruz.
                string secilenOdemeYontemi= comboBoxOdemeYontemleri.SelectedItem.ToString(); //Kullan�c�n�n se�ti�i �deme y�ntemini comboboxdan al�yoruz.

                Type secilenOdemeninSinifi=Assembly.GetExecutingAssembly() //�u anda �al��an program�n i�indeki tan�ml� t�m tipleri ald�k
                                                   .GetTypes() //Bu assembly i�indeki t�m s�n�f, interface veb. tipleri getirdik.
                                                   .FirstOrDefault(t => t.Name == secilenOdemeYontemi); //Kullan�c�n�n se�ti�i �deme y�nteminin s�n�f�n� al�yoruz.

                if (secilenOdemeninSinifi != null)
                {
                    //Reflection kullanarak �al��ma zaman�nda bir s�n�f�n �rne�ini olu�turduk.
                    IOdeme odemeNesnesi = (IOdeme)Activator.CreateInstance(secilenOdemeninSinifi);
                    string sonuc = odemeNesnesi.Ode(tutar);
                    labelSonuc.Text = sonuc;
                }
                else
                {
                    labelSonuc.Text = "Ge�ersiz �deme y�ntemi se�ildi.";
                }
            }
            catch (Exception ex)
            {
                labelSonuc.Text = $"Hata: {ex.Message}";
            }
        }
    }
}
