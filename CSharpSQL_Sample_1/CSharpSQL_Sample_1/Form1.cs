using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpSQL_Sample_1
{
    public partial class Form1 : Form
    {
        SqlConnection connect; //Sql bağlantı nesnemiz
        SqlCommand cmd; //Sql sorgu nesnemiz

        //Connection String
        string conString = @"Server=tcp:kodfest-server.database.windows.net,1433;
            Data Source=kodfest-server.database.windows.net;Initial Catalog=kodfest;
            Persist Security Info=False;User ID={user_name};Password={user_password};
            Pooling=False;MultipleActiveResultSets=False;Encrypt=True;
            TrustServerCertificate=False;Connection Timeout=30;";

        public Form1()
        {
            InitializeComponent();
        }
        private void readBtn_Click(object sender, EventArgs e)
        {
            /*
            Her okuma işleminde verilerin tekrar yazılmasını 
            engelllemek için listbox temizleniyor.
            */
            DataListBox.Items.Clear();

            //connect objesine ConnectionString parametreli atama
            connect = new SqlConnection(conString);

            connect.Open(); //Veri tabanı bağlantısı başlatılıyor

            /*
            Persons tablosundaki tüm kayıtların FirstName bilgilerini 
            getiren sorguyu cmd nesnesine atama
            */
            cmd = new SqlCommand("select FirstName from Persons", connect);

            /* 
            Veri okuma işlemleri için kullanılan
            .sqlDataReader tipinde PersonsReader objesine
            okuma yapacak işlemi atama
            */
            SqlDataReader PersonsReader = cmd.ExecuteReader();

            /*
            PersonsReade'dan okuma yapıldıkça
            her kaydın FirstName değeri DataListBox'a eklenir 
            */
            while (PersonsReader.Read())
            {
                DataListBox.Items.Add(PersonsReader["FirstName"].ToString());
            }

            //İşlemler sona erince bağlantı kapatılır.

            connect.Dispose(); // veya connect.Close();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            connect = new SqlConnection(conString);

            connect.Open();

            //Person ekleme sorgusu
            cmd = new SqlCommand
                ("INSERT INTO Persons (FirstName,LastName) VALUES (@FirstName, @LastName)"
                , connect);

            //FirstName Parametresi texbox'dan alınıyor.
            cmd.Parameters.AddWithValue("@FirstName", FirstNameTxtBox.Text);

            //LasstName Parametresi texbox'dan alınıyor.
            cmd.Parameters.AddWithValue("@LastName", LastNameTxtBox.Text);

            cmd.ExecuteNonQuery(); //sorgu çalıştırılıyor

            connect.Dispose();
        }
    }
}
