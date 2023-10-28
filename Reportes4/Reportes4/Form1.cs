using Microsoft.Reporting.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace Reportes4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-TN05UQ7\\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True");
            SqlCommand comando= new SqlCommand("select * from materias", conexion);
            SqlDataAdapter d = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\\Users\\Usuario\\OneDrive\\Escritorio\\Facultad\\Tecnologías de desarrollo de software IDE\\Práctica\\Practica Parcial\\Reportes4\\Reportes4\\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}