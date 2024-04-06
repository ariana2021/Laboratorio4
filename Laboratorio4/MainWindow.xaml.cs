using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laboratorio4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        private string connectionString = "Data Source=LAB1504-19\\SQLEXPRESS;Initial Catalog=Neptuno;User Id=TecsupAriana;Password=1234567";
        private DataTable dataTable = new DataTable();

       

        private void CargarDatos()
        {
            try
            {
                List<Proveedor> proveedores = new List<Proveedor>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("USP_ListarProveedores", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int idProveedor = reader.GetInt32(reader.GetOrdinal("idProveedor"));
                        string nombreCompañia = reader.GetString(reader.GetOrdinal("nombreCompañia"));
                        string nombreContacto = reader.GetString(reader.GetOrdinal("nombreContacto"));
                        string cargocontacto = reader.GetString(reader.GetOrdinal("cargocontacto"));
                        string direccion = reader.GetString(reader.GetOrdinal("direccion"));
                        proveedores.Add(new Proveedor { idProveedor = idProveedor, nombreCompañia = nombreCompañia, nombreContacto = nombreContacto, cargocontacto = cargocontacto, direccion = direccion });
                    }
                    connection.Close();
                }
                dataGridProveedores.ItemsSource = proveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}