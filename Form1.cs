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
                decimal tutar = Convert.ToDecimal(textBox1.Text); //Kullanýcýnýn girdiði tutarý textboxtan alýyoruz.
                string secilenOdemeYontemi= comboBoxOdemeYontemleri.SelectedItem.ToString(); //Kullanýcýnýn seçtiði ödeme yöntemini comboboxdan alýyoruz.

                Type secilenOdemeninSinifi=Assembly.GetExecutingAssembly() //Þu anda çalýþan programýn içindeki tanýmlý tüm tipleri aldýk
                                                   .GetTypes() //Bu assembly içindeki tüm sýnýf, interface veb. tipleri getirdik.
                                                   .FirstOrDefault(t => t.Name == secilenOdemeYontemi); //Kullanýcýnýn seçtiði ödeme yönteminin sýnýfýný alýyoruz.

                if (secilenOdemeninSinifi != null)
                {
                    //Reflection kullanarak çalýþma zamanýnda bir sýnýfýn örneðini oluþturduk.
                    IOdeme odemeNesnesi = (IOdeme)Activator.CreateInstance(secilenOdemeninSinifi);
                    string sonuc = odemeNesnesi.Ode(tutar);
                    labelSonuc.Text = sonuc;
                }
                else
                {
                    labelSonuc.Text = "Geçersiz ödeme yöntemi seçildi.";
                }
            }
            catch (Exception ex)
            {
                labelSonuc.Text = $"Hata: {ex.Message}";
            }
        }
    }
}
