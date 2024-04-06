using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

public class Proveedor
{
    public int idProveedor { get; set; }
    public string nombreCompañia { get; set; }
    public string nombreContacto { get; set; }
    public string cargocontacto { get; set; }
    public string direccion { get; set; }
}


