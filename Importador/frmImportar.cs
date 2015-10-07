using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Importador
{
    public partial class frmImportar : Form
    {
        //Objeto conexion
        OleDbConnection _AccessConnection;
        MySqlConnection _MySQLConnection;

        public frmImportar()
        {
            InitializeComponent();
            chklbTablas.Items.Add("Calles");
            chklbTablas.Items.Add("Barrios");
            chklbTablas.Items.Add("Categorias");
            chklbTablas.Items.Add("Conexiones");
            chklbTablas.Items.Add("Documentos");
            chklbTablas.Items.Add("EstadosPago");
            chklbTablas.Items.Add("Materiales");
            chklbTablas.Items.Add("Medianeras");
            chklbTablas.Items.Add("Movimientos");
            chklbTablas.Items.Add("Provincias");
            chklbTablas.Items.Add("SituacionEspecial");
            chklbTablas.Items.Add("Zonas");
            chklbTablas.Items.Add("Cajas");
            chklbTablas.Items.Add("Conceptos");
            chklbTablas.Items.Add("Formulas");
            chklbTablas.Items.Add("EstadosSocios");
            chklbTablas.Items.Add("Intimaciones");
            chklbTablas.Items.Add("Impuestos");
            chklbTablas.Items.Add("Terminales");
            chklbTablas.Items.Add("Eventos");
            chklbTablas.Items.Add("Tarifas");
            chklbTablas.Items.Add("Periodos");
            chklbTablas.Items.Add("Socios");
            chklbTablas.Items.Add("Acciones");
            chklbTablas.Items.Add("Convenios");
            chklbTablas.Items.Add("CuentasCorrientes");
            chklbTablas.Items.Add("Cobranzas");
            chklbTablas.Items.Add("Facturas");
            chklbTablas.Items.Add("Detalles");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklbTablas.Items.Count; i++)
            {
                chklbTablas.SetItemChecked(i, true);
            }
        }

        private void lblNinguno_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chklbTablas.Items.Count; i++)
            {
                chklbTablas.SetItemChecked(i, false);
            }
        }

        private void Append_to_Log(string Text_to_append)
        {
            txtResultado.Text += Text_to_append;
            txtResultado.SelectionStart = txtResultado.Text.Length;
            txtResultado.ScrollToCaret();
            Application.DoEvents();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            _AccessConnection = AbreConexionAccess();

            if (_AccessConnection == null)
            {
                MessageBox.Show("No se pudo abrir la conexión a la base de access 'Coop.mdb'");
            }
            else
            {
                _MySQLConnection = dbConectorMySql.ObtenerConexion();

                if (_MySQLConnection == null)
                {
                    MessageBox.Show("No se pudo abrir la conexión a la base de MySQL");
                }
                else
                {
                    // Limpia textbox de resultados
                    txtResultado.Text = "";

                    // Importa las distintas tablas
                    for (int i = 0; i < chklbTablas.Items.Count; i++)
                    {
                        if (chklbTablas.GetItemCheckState(i) == CheckState.Checked)
                        {
                            string Tabla = (string)chklbTablas.Items[i];
                            switch (Tabla)
                            {
                                case "Calles":
                                    ImportarCalles();
                                    break;
                                case "Barrios":
                                    ImportarBarrios();
                                    break;
                                case "Categorias":
                                    ImportarCategorias();
                                    break;
                                case "Conexiones":
                                    ImportarConexiones();
                                    break;
                                case "Documentos":
                                    ImportarDocumentos();
                                    break;
                                case "EstadosPago":
                                    ImportarEstadosPago();
                                    break;
                                case "Materiales":
                                    ImportarMateriales();
                                    break;
                                case "Medianeras":
                                    ImportarMedianeras();
                                    break;
                                case "Movimientos":
                                    ImportarMovimientos();
                                    break;
                                case "Provincias":
                                    ImportarProvincias();
                                    break;
                                case "SituacionEspecial":
                                    ImportarSituacionEspecial();
                                    break;
                                case "Zonas":
                                    ImportarZonas();
                                    break;
                                case "Cajas":
                                    ImportarCajas();
                                    break;
                                case "Conceptos":
                                    ImportarConceptos();
                                    break;
                                case "Formulas":
                                    ImportarFormulas();
                                    break;
                                case "EstadosSocios":
                                    ImportarEstadosSocios();
                                    break;
                                case "Intimaciones":
                                    ImportarIntimaciones();
                                    break;
                                case "Impuestos":
                                    ImportarImpuestos();
                                    break;
                                case "Terminales":
                                    ImportarTerminales();
                                    break;
                                case "Eventos":
                                    ImportarEventos();
                                    break;
                                case "Tarifas":
                                    ImportarTarifas();
                                    break;
                                case "Periodos":
                                    ImportarPeriodos();
                                    break;
                                case "Socios":
                                    ImportarSocios();
                                    break;
                                case "Acciones":
                                    ImportarAcciones();
                                    break;
                                case "Convenios":
                                    ImportarConvenios();
                                    break;
                                case "CuentasCorrientes":
                                    ImportarCuentasCorrientes();
                                    break;
                                case "Cobranzas":
                                    ImportarCobranzas();
                                    break;
                                case "Facturas":
                                    ImportarFacturas();
                                    break;
                                case "Detalles":
                                    ImportarDetalles();
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private OleDbConnection AbreConexionAccess()
        {
            try
            {
                //Creo la cadena de conexion para Office 2007
                string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\coop.mdb;Persist Security Info=False";
                //string cadena = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\WorkSpace\RiquelmePincheira\GitHub\Base datos\Coop 2014-04-14\coop.mdb;Persist Security Info=False";

                //Objeto conexion
                OleDbConnection myConnection = new OleDbConnection(cadena);

                //Abro la conexion
                myConnection.Open();

                // Devuleve conexion
                return myConnection;
            }
            catch (Exception ex)
            {
                // Devuelve nulo
                return null;
            }
        }

        private void ImportarCalles()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_calles ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_calles;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM calles", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblCalles");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblCalles"];

                Append_to_Log("Importando cod_calles ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_calles(id_calle,calle,normalizado) VALUES('" +
                        Datos.Rows[i]["IDCalle"].ToString() + "','" +
                        Datos.Rows[i]["Nombre"].ToString() + "','" +
                        Datos.Rows[i]["Normalizado"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }

        }

        private void ImportarBarrios()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_barrios ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_barrios;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM barrios", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblBarrios");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblBarrios"];

                Append_to_Log("Importando cod_barrios ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_barrios(id_barrio,barrio) VALUES('" +
                        Datos.Rows[i]["ID_Barrio"].ToString() + "','" +
                        Datos.Rows[i]["Barrio"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarCategorias()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_categorias ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_categorias;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Categorias", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblCategorias");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblCategorias"];

                Append_to_Log("Importando cod_categorias ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_categorias(id_categoria,categoria) VALUES('" +
                        Datos.Rows[i]["ID_Categoria"].ToString() + "','" +
                        Datos.Rows[i]["Categoria"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarConexiones()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_conexiones ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_conexiones;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM TiposConex", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblConexiones");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblConexiones"];

                Append_to_Log("Importando cod_conexiones ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_conexiones(id_conexion,conexion) VALUES('";
                    // ID_Conexion comenzaba en 0, se cambia a +1
                    int Codigo = Convert.ToInt32(Datos.Rows[i]["ID_Conexion"].ToString()) + 1;
                    SQLCommand += Convert.ToString(Codigo) + "','" + Datos.Rows[i]["Conexion"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarDocumentos()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_documentos ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_documentos;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM TiposDoc", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblDocumentos");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblDocumentos"];

                Append_to_Log("Importando cod_documentos ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_documentos(id_documento,documento) VALUES('";
                    // ID_TipoDoc comenzaba en 0, se cambia a +1
                    int Codigo = Convert.ToInt32(Datos.Rows[i]["ID_TipoDoc"].ToString()) + 1;
                    SQLCommand += Convert.ToString(Codigo) + "','" + Datos.Rows[i]["TipoDoc"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarEstadosPago()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_estados_pago ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_estados_pago;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM EstadosPago", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblEstadosPago");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblEstadosPago"];

                Append_to_Log("Importando cod_estados_pago ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_estados_pago(id_estado_pago,estado_pago) VALUES('" +
                        Datos.Rows[i]["ID_EstadoPago"].ToString() + "','" +
                        Datos.Rows[i]["EstadoPago"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarMateriales()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_materiales ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_materiales;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM TiposMaterial", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblTiposMaterial");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblTiposMaterial"];

                Append_to_Log("Importando cod_materiales ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_materiales(id_material,material) VALUES('";
                    // ID_Material comenzaba en 0, se cambia a +1
                    int Codigo = Convert.ToInt32(Datos.Rows[i]["ID_Material"].ToString()) + 1;
                    SQLCommand += Convert.ToString(Codigo) + "','" + Datos.Rows[i]["Material"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarMedianeras()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_medianeras ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_medianeras;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM TiposMedianera", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblTiposMedianera");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblTiposMedianera"];

                Append_to_Log("Importando cod_medianeras ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_medianeras(id_medianera,medianera) VALUES('";
                    // ID_Medianera comenzaba en 0, se cambia a +1
                    int Codigo = Convert.ToInt32(Datos.Rows[i]["ID_Medianera"].ToString()) + 1;
                    SQLCommand += Convert.ToString(Codigo) + "','" + Datos.Rows[i]["Medianera"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarMovimientos()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_movimientos ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_movimientos;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM TipoMovim", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblTipoMovim");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblTipoMovim"];

                Append_to_Log("Importando cod_movimientos ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_movimientos(id_movimiento,movimiento) VALUES('" +
                        Datos.Rows[i]["ID_Movimiento"].ToString() + "','" +
                        Datos.Rows[i]["Descripción"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarProvincias()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_provincias ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_provincias;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Provincias", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblProvincias");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblProvincias"];

                Append_to_Log("Importando cod_provincias ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_provincias(id_provincia,provincia) VALUES('" +
                        Datos.Rows[i]["IDProvincia"].ToString() + "','" +
                        Datos.Rows[i]["Nombre"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarSituacionEspecial()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_situacion_especial ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_situacion_especial;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM SituacionEspecial", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblSituacionEspecial");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblSituacionEspecial"];

                Append_to_Log("Importando cod_situacion_especial ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    // ID_Situacion comenzaba en 0, se cambia a +1
                    string SQLCommand = "INSERT INTO cod_situacion_especial(id_situacion_especial,situacion_especial) VALUES('";
                    int Codigo = Convert.ToInt32(Datos.Rows[i]["ID_Situacion"].ToString()) + 1;
                    SQLCommand += Convert.ToString(Codigo) + "','" + Datos.Rows[i]["Situacion"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarZonas()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_zonas ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_zonas;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Zonas", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblZonas");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblZonas"];

                Append_to_Log("Importando cod_zonas ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_zonas(id_zona,zona,imprimir) VALUES('" +
                        Datos.Rows[i]["ID_Zona"].ToString() + "','" +
                        Datos.Rows[i]["Zona"].ToString() + "'," +
                        Datos.Rows[i]["Imprimir"].ToString() + ");";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarCajas()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_cajas ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_cajas;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Cajas", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblCajas");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblCajas"];

                Append_to_Log("Importando cod_cajas ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_cajas(id_caja,caja,fecha_cobro_distinta,caja_activa,cobro_manual) VALUES('" +
                        Datos.Rows[i]["ID_Caja"].ToString() + "','" +
                        Datos.Rows[i]["Descripción"].ToString() + "'," +
                        Datos.Rows[i]["FechaCobroDistinta"].ToString() + "," +
                        Datos.Rows[i]["CajaActiva"].ToString() + "," +
                        Datos.Rows[i]["CobroManual"].ToString() + ");";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarConceptos()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_conceptos ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_conceptos;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Conceptos", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblConceptos");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblConceptos"];

                Append_to_Log("Importando cod_conceptos ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    if (Datos.Rows[i]["OrdenConcepto"].ToString() != "")
                    {
                        string SQLCommand = "INSERT INTO cod_conceptos(id_concepto, concepto, orden_concepto, activo," +
                            "id_formula, variable, tipo_signo, concepto_particular, aplicar_iva, aplicar_recargo, " +
                            "aplicar_descuento) VALUES('" +
                            Datos.Rows[i]["ID_Concepto"].ToString() + "','" +
                            Datos.Rows[i]["Descripción"].ToString() + "','" +
                            Datos.Rows[i]["OrdenConcepto"].ToString() + "'," +
                            Datos.Rows[i]["Activo"].ToString() + ",'" +
                            Datos.Rows[i]["Fórmula"].ToString() + "','" +
                            Datos.Rows[i]["Variable"].ToString().Replace(",", ".") + "','" +
                            Datos.Rows[i]["TipoSigno"].ToString() + "',";
                        if (Datos.Rows[i]["Aplicacion"].ToString() == "2")
                        {
                            SQLCommand += "True,";
                        }
                        else
                        {
                            SQLCommand += "False,";
                        }
                        SQLCommand += Datos.Rows[i]["AplicarIVA"].ToString() + "," +
                        Datos.Rows[i]["AplicarRecargo"].ToString() + "," +
                        Datos.Rows[i]["AplicarDescuento"].ToString() + ");";
                        MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                        int p = cmd.ExecuteNonQuery();
                    };
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarFormulas()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_formulas ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_formulas;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                Append_to_Log("Importando cod_formulas ... ");

                string SQLCommand = "INSERT INTO cod_formulas(`id_formula`,`formula`,`descripcion`) VALUES " +
                    "(1,'Tarifa básica','Tarifa básica')," +
                    "(2,'Variable por tarifa básica','Variable por tarifa básica o (Abono + Consumo Excedente)')," +
                    "(3,'Consumo por ValorM3','Consumo excedente por ValorM3')," +
                    "(4,'Consumo por Variable','Abono por ValorM3')," +
                    "(5,'Consumo por ValorM3 por Variable','Consumo por ValorM3 por Variable')," +
                    "(6,'Cuota Acciones','Cuota Acciones')," +
                    "(7,'Variable por Cuota Acciones','Variable por Cuota Acciones')," +
                    "(8,'Cuota Convenio de pago','Cuota Convenio de pago')," +
                    "(9,'Variable por Cuota Convenio','Variable por Cuota Convenio')," +
                    "(10,'Importe fijo','Importe fijo según concepto')," +
                    "(11,'Importe variable (sin uso)','Importe variable que se calcula en el momento')," +
                    "(12,'Importe fijo según Concepto Particular','Importe fijo según Conceptos Particulares')";
                MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarEstadosSocios()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_estados_socios ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_estados_socios;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Estados", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblEstados");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblEstados"];

                Append_to_Log("Importando cod_estados_socios ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_estados_socios(id_estado_socio, estado_socio, facturar, " +
                        "requiere_fin, seleccionable, duracion_meses) VALUES ('" +
                        Datos.Rows[i]["ID_Estado"].ToString() + "','" +
                        Datos.Rows[i]["Estado"].ToString() + "'," +
                        Datos.Rows[i]["Facturar"].ToString() + "," +
                        Datos.Rows[i]["RequiereFin"].ToString() + "," +
                        Datos.Rows[i]["Seleccionable"].ToString() + ",'" +
                        Datos.Rows[i]["MesesVenc"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarIntimaciones()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_intimaciones ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_intimaciones;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM TipoIntimacion", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblTipoIntimacion");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblTipoIntimacion"];

                Append_to_Log("Importando cod_intimaciones ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_intimaciones(id_intimacion, intimacion) VALUES ('" +
                        Datos.Rows[i]["ID_TipoIntimación"].ToString() + "','" +
                        Datos.Rows[i]["Descripción"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarImpuestos()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cod_impuestos ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cod_impuestos;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM TiposIVA", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblTiposIVA");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblTiposIVA"];

                Append_to_Log("Importando cod_impuestos ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO cod_impuestos (id_impuesto, impuesto, porcentaje, " +
                        "vigencia_desde, vigencia_hasta, credito_fiscal, activo) VALUES ('";

                    // Almacena el código de impuesto
                    int new_id_impuesto = Convert.ToInt32(Datos.Rows[i]["ID_IVA"].ToString());
                    // Renumera los impuestos viejos
                    if (new_id_impuesto < 20)
                    {
                        // ID_IVA comenzaba en 0, se cambia a +1
                        new_id_impuesto += 1;
                    }
                    else
                    {
                        // ID_IVA que comenzaban en 96, se cambian a partir de 15
                        new_id_impuesto -= 81;
                    };
                    SQLCommand += new_id_impuesto.ToString() + "','" +
                        Datos.Rows[i]["Descripción"].ToString() + "','" +
                        Datos.Rows[i]["Porcentaje"].ToString().Replace(",", ".") + "',NULL,NULL," +
                        Datos.Rows[i]["CreditoFiscal"].ToString() + ",";
                    if (new_id_impuesto <= 14)
                    {
                        // Se marcan como inactivos los códigos de impuestos viejos
                        SQLCommand += "False);";
                    }
                    else
                    {
                        // Se marcan como activos los códigos de impuestos actuales
                        SQLCommand += "True);";
                    };
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarTerminales()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla seg_terminales ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE seg_terminales;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Terminales", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblTerminales");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblTerminales"];

                Append_to_Log("Importando seg_terminales ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO seg_terminales (id_terminal, terminal, " +
                        "habilitada, bloqueada, intento_nro, fecha_bloqueo) VALUES ('";
                    int Codigo = Convert.ToInt32(Datos.Rows[i]["ID_Terminal"].ToString()) + 1;
                    SQLCommand += Convert.ToString(Codigo) + "','" +
                        Datos.Rows[i]["Nombre"].ToString() + "',True,False,'0',NULL);";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarEventos()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla seg_codigos_eventos ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE seg_codigos_eventos;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Eventos", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblEventos");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblEventos"];

                Append_to_Log("Importando seg_codigos_eventos ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO seg_codigos_eventos(id_evento,descripcion) VALUES('" +
                        Datos.Rows[i]["ID_Evento"].ToString() + "','" +
                        Datos.Rows[i]["Descripción"].ToString() + "');";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarTarifas()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla tarifas ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE tarifas;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Tarifas", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblTarifas");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblTarifas"];

                Append_to_Log("Importando tarifas ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    string SQLCommand = "INSERT INTO tarifas (id_tarifa, tarifa, abreviatura, cargo_fijo, " +
                        "valor_m3, abono, usuario_residencial, bonificacion, recargo_minimo, " +
                        "requiere_fin, meses_venc, activa) VALUES ('" +
                        Datos.Rows[i]["ID_Tarifa"].ToString() + "','" +
                        Datos.Rows[i]["Tarifa"].ToString() + "','" +
                        Datos.Rows[i]["Abreviatura"].ToString() + "','" +
                        Datos.Rows[i]["CargoFijo"].ToString().Replace(",", ".") + "','" +
                        Datos.Rows[i]["ValorM3"].ToString().Replace(",", ".") + "','" +
                        Datos.Rows[i]["Abono"].ToString().Replace(",", ".") + "'," +
                        Datos.Rows[i]["UsuarioResidencial"].ToString() + "," +
                        Datos.Rows[i]["Bonificación"].ToString() + "," +
                        Datos.Rows[i]["RecargoMínimo"].ToString() + "," +
                        Datos.Rows[i]["RequiereFin"].ToString() + ",'" +
                        Datos.Rows[i]["MesesVenc"].ToString() + "'," +
                        Datos.Rows[i]["TarifaActiva"].ToString() + ");";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarPeriodos()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla periodos ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE periodos;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Periodos", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblPeriodos");

                //Creo el miembro de datos del DataGridView
                DataTable Datos = dsDatos.Tables["TblPeriodos"];

                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando periodos ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario

                    string SQLCommand = "INSERT INTO periodos (id_periodo, fecha_facturacion, fecha_primer_venc, " +
                        "fecha_segundo_venc, fecha_tercer_venc, facturado) VALUES ('" +
                        Datos.Rows[i]["ID_Periodo"].ToString() + "',";
                    if (Datos.Rows[i]["FechaFacturación"].ToString() != "")
                    {
                        SQLCommand += "'" + Convert.ToDateTime(Datos.Rows[i]["FechaFacturación"].ToString()).ToString("yyyy-MM-dd").ToString() + "',";
                    }
                    else
                    {
                        SQLCommand += "NULL,";
                    };
                    if (Datos.Rows[i]["FechaPrimerVenc"].ToString() != "")
                    {
                        SQLCommand += "'" + Convert.ToDateTime(Datos.Rows[i]["FechaPrimerVenc"].ToString()).ToString("yyyy-MM-dd").ToString() + "',";
                    }
                    else
                    {
                        SQLCommand += "NULL,";
                    };
                    if (Datos.Rows[i]["FechaSegundoVenc"].ToString() != "")
                    {
                        SQLCommand += "'" + Convert.ToDateTime(Datos.Rows[i]["FechaSegundoVenc"].ToString()).ToString("yyyy-MM-dd").ToString() + "',";
                    }
                    else
                    {
                        SQLCommand += "NULL,";
                    };
                    if (Datos.Rows[i]["FechaTercerVenc"].ToString() != "")
                    {
                        SQLCommand += "'" + Convert.ToDateTime(Datos.Rows[i]["FechaTercerVenc"].ToString()).ToString("yyyy-MM-dd").ToString() + "',";
                    }
                    else
                    {
                        SQLCommand += "NULL,";
                    };
                    SQLCommand += Datos.Rows[i]["Facturado"].ToString() + ");";
                    MySqlCommand cmd = new MySqlCommand(SQLCommand, _MySQLConnection);
                    int p = cmd.ExecuteNonQuery();
                }
                // Oculta la barra de progreso
                pgbProgreso.Visible = false;

                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarSocios()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla socios ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE socios;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();

                Append_to_Log("Limpiando tabla socios_conexion ... OK" + Environment.NewLine);
                cmd = new MySqlCommand("TRUNCATE TABLE socios_conexion;", _MySQLConnection);
                p = cmd.ExecuteNonQuery();

                Append_to_Log("Limpiando tabla socios_debito_bancario ... OK" + Environment.NewLine);
                cmd = new MySqlCommand("TRUNCATE TABLE socios_debito_bancario;", _MySQLConnection);
                p = cmd.ExecuteNonQuery();

                Append_to_Log("Limpiando tabla socios_lote ... OK" + Environment.NewLine);
                cmd = new MySqlCommand("TRUNCATE TABLE socios_lote;", _MySQLConnection);
                p = cmd.ExecuteNonQuery();

                Append_to_Log("Limpiando tabla socios_varios ... OK" + Environment.NewLine);
                cmd = new MySqlCommand("TRUNCATE TABLE socios_varios;", _MySQLConnection);
                p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Socios", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblSocios");

                //Creo el Datatable
                DataTable Datos = dsDatos.Tables["TblSocios"];

                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando socios, socios_conexion, socios_debito_bancario, socios_lote, socios_varios ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario
                    // Inserta en la tabla socios
                    // ==========================
                    MySqlCommand SQLCommand = new MySqlCommand("INSERT INTO socios (id_socio, codigo_socio, " +
                        "subcodigo_socio, nombre, tipo_documento, documento, fecha_alta, estado, fin_estado, " +
                        "tarifa, fin_tarifa, iva, cuit, categoria, observaciones) VALUES (@id_socio, " +
                        "@codigo_socio, @subcodigo_socio, @nombre, @tipo_documento, @documento, @fecha_alta, " +
                        "@estado, @fin_estado, @tarifa, @fin_tarifa, @iva, @cuit, @categoria, @observaciones);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_socio", Datos.Rows[i]["ID_Socio"].ToString());
                    SQLCommand.Parameters.AddWithValue("@codigo_socio", Datos.Rows[i]["CodSocio"].ToString());
                    SQLCommand.Parameters.AddWithValue("@subcodigo_socio", Datos.Rows[i]["SubCodSocio"].ToString());
                    SQLCommand.Parameters.AddWithValue("@nombre", Datos.Rows[i]["Nombre"].ToString());

                    try
                    {
                        int Codigo = Convert.ToInt32(Datos.Rows[i]["TipoDoc"].ToString()) + 1;
                        SQLCommand.Parameters.AddWithValue("@tipo_documento", Codigo);
                    }
                    catch
                    {
                        SQLCommand.Parameters.AddWithValue("@tipo_documento", null);
                    };

                    SQLCommand.Parameters.AddWithValue("@documento", Datos.Rows[i]["Documento"].ToString());

                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["FechaAlta"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fecha_alta", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch
                    {
                        SQLCommand.Parameters.AddWithValue("@fecha_alta", null);
                    };

                    SQLCommand.Parameters.AddWithValue("@estado", Datos.Rows[i]["Estado"].ToString());
                    SQLCommand.Parameters.AddWithValue("@fin_estado", Datos.Rows[i]["FinSuspension"].ToString());
                    SQLCommand.Parameters.AddWithValue("@tarifa", Datos.Rows[i]["Tarifa"].ToString());
                    SQLCommand.Parameters.AddWithValue("@fin_tarifa", Datos.Rows[i]["FinTarifa"].ToString());

                    try
                    {
                        int new_id_impuesto = Convert.ToInt32(Datos.Rows[i]["IVA"].ToString());
                        if (new_id_impuesto < 20)
                        { new_id_impuesto += 1; }
                        else
                        { new_id_impuesto -= 81; };
                        SQLCommand.Parameters.AddWithValue("@iva", new_id_impuesto);
                    }
                    catch
                    {
                        SQLCommand.Parameters.AddWithValue("@iva", null);
                    };

                    SQLCommand.Parameters.AddWithValue("@cuit", Datos.Rows[i]["CUIT"].ToString());
                    SQLCommand.Parameters.AddWithValue("@categoria", Datos.Rows[i]["Categoría"].ToString());
                    SQLCommand.Parameters.AddWithValue("@observaciones", Datos.Rows[i]["Observaciones"].ToString());

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }

                    // Inserta en la tabla socios_conexion
                    // ===================================
                    SQLCommand = new MySqlCommand("INSERT INTO socios_conexion (id_Socio, ubicacion_servicio, " +
                        "medianera, tipo_conexion, distancia_a_red, profundidad_red, tipo_material, " +
                        "diametro_red, medidor, marca_medidor, barrio, calle, calle_altura, piso, dpto, " +
                        "distrito_electoral, zona, adic_domicilio) VALUES (@id_Socio, @ubicacion_servicio, " +
                        "@medianera, @tipo_conexion, @distancia_a_red, @profundidad_red, @tipo_material, " +
                        "@diametro_red, @medidor, @marca_medidor, @barrio, @calle, @calle_altura, @piso, @dpto, " +
                        "@distrito_electoral, @zona, @adic_domicilio);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_socio", Datos.Rows[i]["ID_Socio"].ToString());

                    try
                    {
                        float Codigo = Convert.ToSingle(Datos.Rows[i]["UbicServicio"].ToString());
                        SQLCommand.Parameters.AddWithValue("@ubicacion_servicio", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@ubicacion_servicio", null); };

                    try
                    {
                        int Codigo = Convert.ToInt32(Datos.Rows[i]["Medianera"].ToString()) + 1;
                        SQLCommand.Parameters.AddWithValue("@medianera", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@medianera", null); };

                    try
                    {
                        int Codigo = Convert.ToInt32(Datos.Rows[i]["TipoConexion"].ToString()) + 1;
                        SQLCommand.Parameters.AddWithValue("@tipo_conexion", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@tipo_conexion", null); };

                    try
                    {
                        float Codigo = Convert.ToSingle(Datos.Rows[i]["DistanciaARed"].ToString());
                        SQLCommand.Parameters.AddWithValue("@distancia_a_red", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@distancia_a_red", null); };

                    try
                    {
                        float Codigo = Convert.ToSingle(Datos.Rows[i]["ProfundidadRed"].ToString());
                        SQLCommand.Parameters.AddWithValue("@profundidad_red", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@profundidad_red", null); };

                    try
                    {
                        int Codigo = Convert.ToInt32(Datos.Rows[i]["TipoMaterial"].ToString()) + 1;
                        SQLCommand.Parameters.AddWithValue("@tipo_material", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@tipo_material", null); };

                    try
                    {
                        float Codigo = Convert.ToSingle(Datos.Rows[i]["DiametroRed"].ToString());
                        SQLCommand.Parameters.AddWithValue("@diametro_red", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@diametro_red", null); };

                    SQLCommand.Parameters.AddWithValue("@medidor", Datos.Rows[i]["Medidor"].ToString());
                    SQLCommand.Parameters.AddWithValue("@marca_medidor", Datos.Rows[i]["MarcaMedidor"].ToString());
                    SQLCommand.Parameters.AddWithValue("@barrio", Datos.Rows[i]["Barrio"].ToString());

                    // FALTA: Codificar calle
                    //SQLCommand.Parameters.AddWithValue("@calle", Datos.Rows[i]["Calle"].ToString());
                    SQLCommand.Parameters.AddWithValue("@calle", null);

                    SQLCommand.Parameters.AddWithValue("@calle_altura", Datos.Rows[i]["Nro"].ToString());
                    SQLCommand.Parameters.AddWithValue("@piso", null);
                    SQLCommand.Parameters.AddWithValue("@dpto", null);
                    SQLCommand.Parameters.AddWithValue("@distrito_electoral", Datos.Rows[i]["Distrito"].ToString());
                    SQLCommand.Parameters.AddWithValue("@zona", Datos.Rows[i]["Zona"].ToString());
                    SQLCommand.Parameters.AddWithValue("@adic_domicilio", Datos.Rows[i]["AdicDomic"].ToString());

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }

                    // Insertar en la tabla socios_debito_bancario
                    // ===========================================
                    SQLCommand = new MySqlCommand("INSERT INTO socios_debito_bancario (id_socio, banco, cbu) " +
                        "VALUES (@id_socio, @banco, @cbu);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_socio", Datos.Rows[i]["ID_Socio"].ToString());
                    SQLCommand.Parameters.AddWithValue("@banco", Datos.Rows[i]["DebAutPrestador"].ToString());
                    SQLCommand.Parameters.AddWithValue("@cbu", Datos.Rows[i]["CBU"].ToString());

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }

                    // Insertar en la tabla socios_lote
                    // ================================
                    SQLCommand = new MySqlCommand("INSERT INTO socios_lote (id_Socio, barrio, manzana, lote, " +
                        "calle, calle_altura, piso, dpto, nomenclatura, ruta_reparto, orden_reparto, " +
                        "cp, localidad, provincia, adic_domicilio) VALUES (@id_Socio, @barrio, @manzana, @lote, " +
                        "@calle, @calle_altura, @piso, @dpto, @nomenclatura, @ruta_reparto, @orden_reparto, " +
                        "@cp, @localidad, @provincia, @adic_domicilio);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_Socio", Datos.Rows[i]["ID_Socio"].ToString());

                    if (Datos.Rows[i]["BarrioLegal"].ToString() != "")
                    { SQLCommand.Parameters.AddWithValue("@barrio", Datos.Rows[i]["BarrioLegal"].ToString()); }
                    else
                    { SQLCommand.Parameters.AddWithValue("@barrio", null); };

                    SQLCommand.Parameters.AddWithValue("@manzana", Datos.Rows[i]["Manzana"].ToString());
                    SQLCommand.Parameters.AddWithValue("@lote", Datos.Rows[i]["Lote"].ToString());

                    // FALTA: Codificar calle
                    //SQLCommand.Parameters.AddWithValue("@calle", Datos.Rows[i]["CalleLegal"].ToString());
                    SQLCommand.Parameters.AddWithValue("@calle", null);

                    SQLCommand.Parameters.AddWithValue("@calle_altura", Datos.Rows[i]["NroLegal"].ToString());
                    SQLCommand.Parameters.AddWithValue("@piso", null);
                    SQLCommand.Parameters.AddWithValue("@dpto", null);
                    SQLCommand.Parameters.AddWithValue("@nomenclatura", Datos.Rows[i]["Nomenclatura"].ToString());
                    SQLCommand.Parameters.AddWithValue("@ruta_reparto", Datos.Rows[i]["Ruta"].ToString());
                    SQLCommand.Parameters.AddWithValue("@orden_reparto", Datos.Rows[i]["Orden"].ToString());
                    SQLCommand.Parameters.AddWithValue("@cp", Datos.Rows[i]["CodPostalLegal"].ToString());

                    try
                    {
                        int Codigo = Convert.ToInt32(Datos.Rows[i]["LocalidadLegal"].ToString());
                        SQLCommand.Parameters.AddWithValue("@localidad", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@localidad", null); };

                    try
                    {
                        int Codigo = Convert.ToInt32(Datos.Rows[i]["ProvinciaLegal"].ToString());
                        SQLCommand.Parameters.AddWithValue("@provincia", Codigo);
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@provincia", null); };

                    SQLCommand.Parameters.AddWithValue("@adic_domicilio", Datos.Rows[i]["AdicDomicLegal"].ToString());

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }

                    // Insertar en la tabla socios_varios
                    // ==================================
                    SQLCommand = new MySqlCommand("INSERT INTO socios_varios (id_socio, profesion, conyuge_nombre, " +
                        "conyuge_tipo_documento, conyuge_documento, id_coop_luz, fecha_convenio_coop_luz, " +
                        "situacion_especial) VALUES (@id_socio, @profesion, @conyuge_nombre, " +
                        "@conyuge_tipo_documento, @conyuge_documento, @id_coop_luz, @fecha_convenio_coop_luz, " +
                        "@situacion_especial);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_Socio", Datos.Rows[i]["ID_Socio"].ToString());
                    SQLCommand.Parameters.AddWithValue("@profesion", Datos.Rows[i]["Profesión"].ToString());
                    SQLCommand.Parameters.AddWithValue("@conyuge_nombre", Datos.Rows[i]["Conyuge_Nombre"].ToString());

                    try
                    {
                        int Codigo = Convert.ToInt32(Datos.Rows[i]["Conyuge_TipoDoc"].ToString()) + 1;
                        SQLCommand.Parameters.AddWithValue("@conyuge_tipo_documento", Codigo);
                    }
                    catch
                    {
                        SQLCommand.Parameters.AddWithValue("@conyuge_tipo_documento", null);
                    };

                    SQLCommand.Parameters.AddWithValue("@conyuge_documento", Datos.Rows[i]["Conyuge_Documento"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_coop_luz", Datos.Rows[i]["ID_CoopLuz"].ToString());

                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["FechaConvCoopLuz"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fecha_convenio_coop_luz", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@fecha_convenio_coop_luz", null); };

                    SQLCommand.Parameters.AddWithValue("@situacion_especial", Datos.Rows[i]["SituacionEspecial"].ToString());

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }
                }

                // Oculta la barra de progreso
                pgbProgreso.Visible = false;

                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarAcciones()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla acciones ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE acciones;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Acciones", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblAcciones");

                //Creo el Datatable
                DataTable Datos = dsDatos.Tables["TblAcciones"];

                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando acciones ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario

                    MySqlCommand SQLCommand = new MySqlCommand("INSERT INTO acciones (id_socio, fecha, importe, " +
                        "valor_cuota, cuotas, facturadas, pendientes, finalizado )" +
                        " VALUES (@id_socio, @fecha, @importe, @valor_cuota, @cuotas, @facturadas, " +
                        "@pendientes, @finalizado);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_socio", Datos.Rows[i]["ID_Socio"].ToString());

                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["Fecha"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fecha", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@fecha", null); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Importe"].ToString());
                        SQLCommand.Parameters.AddWithValue("@importe", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@importe", 0); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["ValorCuota"].ToString());
                        SQLCommand.Parameters.AddWithValue("@valor_cuota", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@valor_cuota", 0); };

                    try
                    {
                        int Valor = Convert.ToInt32(Datos.Rows[i]["Cuotas"].ToString());
                        SQLCommand.Parameters.AddWithValue("@cuotas", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@cuotas", 0); };

                    try
                    {
                        int Valor = Convert.ToInt32(Datos.Rows[i]["Facturadas"].ToString());
                        SQLCommand.Parameters.AddWithValue("@facturadas", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@facturadas", 0); };

                    try
                    {
                        int Valor1 = Convert.ToInt32(Datos.Rows[i]["Facturadas"].ToString());
                        int Valor2 = Convert.ToInt32(Datos.Rows[i]["Cuotas"].ToString());
                        SQLCommand.Parameters.AddWithValue("@pendientes", (Valor2 - Valor1));
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@pendientes", 0); };

                    SQLCommand.Parameters.AddWithValue("@finalizado", Convert.ToBoolean(Datos.Rows[i]["Cancelado"].ToString()));

                    SQLCommand.Parameters.AddWithValue("@id_usuario", null);

                    SQLCommand.Parameters.AddWithValue("@id_terminal", null);

                    SQLCommand.Parameters.AddWithValue("@fecha_registro", null);

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }
                }

                // Oculta la barra de progreso
                pgbProgreso.Visible = false;

                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarConvenios()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla convenios ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE convenios;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Convenios ORDER BY ID_Convenio", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblConvenios");

                //Creo el Datatable
                DataTable Datos = dsDatos.Tables["TblConvenios"];

                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando convenios ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario

                    MySqlCommand SQLCommand = new MySqlCommand("INSERT INTO convenios (id_convenio, id_socio, fecha_convenio, " +
                        "importe_total, valor_cuota, cuotas, facturadas, pendientes, finalizado, iva_facturas, cuota_iva, " +
                        "convenio_judicial, porcentaje_descuento_recargo, importe_descuento_recargo, tipo_descuento_recargo, " +
                        "id_usuario, id_terminal, fecha_registro) VALUES (@id_convenio, @id_socio, @fecha_convenio, @importe_total, " +
                        "@valor_cuota, @cuotas, @facturadas, @pendientes, @finalizado, @iva_facturas, @cuota_iva, " +
                        "@convenio_judicial, @porcentaje_descuento_recargo, @importe_descuento_recargo, @tipo_descuento_recargo, " +
                        "@id_usuario, @id_terminal, @fecha_registro);", _MySQLConnection);

                    try
                    {
                        int Valor = Convert.ToInt32(Datos.Rows[i]["ID_Convenio"].ToString()) + 1;
                        SQLCommand.Parameters.AddWithValue("@id_convenio", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@id_convenio", null); };

                    SQLCommand.Parameters.AddWithValue("@id_socio", Datos.Rows[i]["ID_Socio"].ToString());

                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["Fecha"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fecha_convenio", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@fecha_convenio", null); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Importe"].ToString());
                        SQLCommand.Parameters.AddWithValue("@importe_total", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@importe_total", 0); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["ValorCuota"].ToString());
                        SQLCommand.Parameters.AddWithValue("@valor_cuota", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@valor_cuota", 0); };

                    try
                    {
                        int Valor = Convert.ToInt32(Datos.Rows[i]["Cuotas"].ToString());
                        SQLCommand.Parameters.AddWithValue("@cuotas", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@cuotas", 0); };

                    try
                    {
                        int Valor = Convert.ToInt32(Datos.Rows[i]["Facturadas"].ToString());
                        SQLCommand.Parameters.AddWithValue("@facturadas", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@facturadas", 0); };

                    try
                    {
                        int Valor1 = Convert.ToInt32(Datos.Rows[i]["Facturadas"].ToString());
                        int Valor2 = Convert.ToInt32(Datos.Rows[i]["Cuotas"].ToString());
                        SQLCommand.Parameters.AddWithValue("@pendientes", (Valor2 - Valor1));
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@pendientes", 0); };

                    SQLCommand.Parameters.AddWithValue("@finalizado", Convert.ToBoolean(Datos.Rows[i]["Cancelado"].ToString()));

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["IVAFacturas"].ToString());
                        SQLCommand.Parameters.AddWithValue("@iva_facturas", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@iva_facturas", 0); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["CuotaIVA"].ToString());
                        SQLCommand.Parameters.AddWithValue("@cuota_iva", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@cuota_iva", 0); };

                    SQLCommand.Parameters.AddWithValue("@convenio_judicial", Convert.ToBoolean(Datos.Rows[i]["ConvenioJudicial"].ToString()));

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Descuento"].ToString());
                        SQLCommand.Parameters.AddWithValue("@porcentaje_descuento_recargo", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@porcentaje_descuento_recargo", 0); };

                    SQLCommand.Parameters.AddWithValue("@importe_descuento_recargo", 0);

                    try
                    {
                        int Valor = Convert.ToInt32(Datos.Rows[i]["TipoConvenio"].ToString());
                        SQLCommand.Parameters.AddWithValue("@tipo_descuento_recargo", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@tipo_descuento_recargo", null); };

                    SQLCommand.Parameters.AddWithValue("@id_usuario", null);
                    SQLCommand.Parameters.AddWithValue("@id_terminal", null);
                    SQLCommand.Parameters.AddWithValue("@fecha_registro", null);

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }
                }

                // Oculta la barra de progreso
                pgbProgreso.Visible = false;

                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarCuentasCorrientes()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cuentas_corrientes ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cuentas_corrientes;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM CuentasCorrientes ORDER BY ID_Socio, " +
                    "ID_Factura, Fecha, ID_Movimiento", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblCuentasCorrientes");

                //Creo el Datatable
                DataTable Datos = dsDatos.Tables["TblCuentasCorrientes"];

                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando cuentas_corrientes ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario

                    MySqlCommand SQLCommand = new MySqlCommand("INSERT INTO cuentas_corrientes (id_socio, " +
                        "id_factura, id_movimiento, id_cobranza, fecha, importe_debito, importe_credito, " +
                        "importe_saldo) VALUES (@id_socio, @id_factura, @id_movimiento, @id_cobranza, " +
                        "@fecha, @importe_debito, @importe_credito, @importe_saldo);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_socio", Datos.Rows[i]["ID_Socio"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_factura", Datos.Rows[i]["ID_Factura"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_movimiento", Datos.Rows[i]["ID_Movimiento"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_cobranza", Datos.Rows[i]["ID_Caja"].ToString());

                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["Fecha"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fecha", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@fecha", null); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Débitos"].ToString());
                        SQLCommand.Parameters.AddWithValue("@importe_debito", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@importe_debito", 0); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Créditos"].ToString());
                        SQLCommand.Parameters.AddWithValue("@importe_credito", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@importe_credito", 0); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Saldo"].ToString());
                        SQLCommand.Parameters.AddWithValue("@importe_saldo", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@importe_saldo", 0); };

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }
                }

                // Oculta la barra de progreso
                pgbProgreso.Visible = false;

                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarCobranzas()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla cobranzas ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE cobranzas;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Cobranzas", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblCobranzas");

                //Creo el Datatable
                DataTable Datos = dsDatos.Tables["TblCobranzas"];

                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando cobranzas ... ");

                for (int i = 0; i < Datos.Rows.Count; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario

                    MySqlCommand SQLCommand = new MySqlCommand("INSERT INTO cobranzas (id_cobranza, id_caja, " +
                        "id_factura, id_recibo, id_socio, importe, descuento_convenio, iva_descuento_convenio, " +
                        "fecha_cobro, id_usuario, id_terminal, fecha_registro) VALUES (id_cobranza, @id_caja, " +
                        "@id_factura, @id_recibo, @id_socio, @importe, @descuento_convenio, @iva_descuento_convenio, " +
                        "@fecha_cobro, @id_usuario, @id_terminal, @fecha_registro);", _MySQLConnection);

                    SQLCommand.Parameters.AddWithValue("@id_cobranza", Datos.Rows[i]["ID_CompCaja"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_caja", Datos.Rows[i]["ID_Caja"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_factura", Datos.Rows[i]["ID_Factura"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_recibo", Datos.Rows[i]["ID_Recibo"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_socio", Datos.Rows[i]["ID_Socio"].ToString());

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Importe"].ToString());
                        SQLCommand.Parameters.AddWithValue("@importe", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@importe", 0); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["DescConv"].ToString());
                        SQLCommand.Parameters.AddWithValue("@descuento_convenio", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@descuento_convenio", 0); };

                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["IVADescConv"].ToString());
                        SQLCommand.Parameters.AddWithValue("@iva_descuento_convenio", Valor);
                    }
                    catch
                    { SQLCommand.Parameters.AddWithValue("@iva_descuento_convenio", 0); };

                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["FechaCaja"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fecha_cobro", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@fecha_cobro", null); };

                    SQLCommand.Parameters.AddWithValue("@id_usuario", Datos.Rows[i]["ID_Usuario"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_terminal", Datos.Rows[i]["ID_Terminal"].ToString());

                    try
                    {
                        DateTime Fecha1 = Convert.ToDateTime(Datos.Rows[i]["FechaRegistro"].ToString());
                        DateTime Fecha2 = Convert.ToDateTime(Datos.Rows[i]["HoraRegistro"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fecha_registro", Fecha1.ToString("yyyy-MM-dd") + " " +
                            Fecha2.ToString("HH:mm:ss"));
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@fecha_registro", null); };

                    try
                    {
                        int p = SQLCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show(ex.Message);
                    }
                }

                // Oculta la barra de progreso
                pgbProgreso.Visible = false;

                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarFacturas()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla facturas ... OK" + Environment.NewLine);
                MySqlCommand cmdMediciones = new MySqlCommand("TRUNCATE TABLE socios_mediciones;", _MySQLConnection);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE facturas;", _MySQLConnection);
                int pM = cmdMediciones.ExecuteNonQuery();
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Facturas", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();

                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblFacturas");

                //Creo el Datatable
                DataTable Datos = dsDatos.Tables["TblFacturas"];

                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando facturas ... ");
                int temp = this.txtDesde.Text == "" ? 0 : int.Parse(this.txtDesde.Text);
                int temp2 = this.txtHasta.Text == "" ? Datos.Rows.Count : int.Parse(this.txtHasta.Text);
                int i;
                for (i = temp; i < temp2; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario

                    MySqlCommand SQLCommandMediciones = new MySqlCommand("INSERT INTO socios_mediciones ( fecha_lectura, " +
                        "consumo, lectura, id_socio )" +
                        " VALUES (@FLectura, @Consumo, @Lectura, @id_Socio);", _MySQLConnection);

                    // Fecha de lectura debe pasarse...
                    SQLCommandMediciones.Parameters.AddWithValue("@Consumo", Datos.Rows[i]["Consumo"].ToString());
                    SQLCommandMediciones.Parameters.AddWithValue("@id_Socio", Datos.Rows[i]["id_Socio"].ToString());
                   
                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["FLectura"].ToString());
                        SQLCommandMediciones.Parameters.AddWithValue("@fLectura", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch { SQLCommandMediciones.Parameters.AddWithValue("@fLectura", null); };
                    int p;
                    try
                    {
                        Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Lectura"].ToString());
                        SQLCommandMediciones.Parameters.AddWithValue("@Lectura", Valor);
                    }
                    catch
                    {
                        SQLCommandMediciones.Parameters.AddWithValue("@Lectura", 0); };
                    try
                    {
                         p = SQLCommandMediciones.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        p=0;
                        DialogResult result = MessageBox.Show(ex.Message);
                    }

                    MySqlCommand SQLCommand = new MySqlCommand("INSERT INTO facturas (id_factura, id_periodo, " +
                        "id_socio, id_medicion, id_estadoPago, id_Tarifa, id_convenio, fechaPago, cobrado, neto1, neto2," +
                        " importeNeto, importeTotal) VALUES (@id_Factura, @id_Periodo, @id_Socio, @id_medicion, " +
                        "@id_estadoPago, @id_Tarifa,@id_convenio,@fechaPago, @cobrado, @neto1, @neto2,@importeNeto, @importeTotal);", _MySQLConnection);
                    // Fecha de lectura debe pasarse...
                    SQLCommand.Parameters.AddWithValue("@id_Factura", Datos.Rows[i]["id_Factura"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_Periodo", Datos.Rows[i]["id_periodo"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_Socio", Datos.Rows[i]["id_Socio"].ToString());
                    SQLCommand.Parameters.AddWithValue("@id_medicion",p.ToString());
                    SQLCommand.Parameters.AddWithValue("@id_estadoPago", Datos.Rows[i]["EstadoPago"].ToString());
                    SQLCommand.Parameters.AddWithValue("@cobrado", Datos.Rows[i]["cobrado"].ToString());
                    try
                    {
                        SQLCommand.Parameters.AddWithValue("@neto1", Convert.ToDecimal(Datos.Rows[i]["neto1"].ToString()));
                    }catch { SQLCommand.Parameters.AddWithValue("@neto1",null); }
                    try
                    {
                        SQLCommand.Parameters.AddWithValue("@neto2", Convert.ToDecimal(Datos.Rows[i]["neto2"].ToString()));
                    }catch { SQLCommand.Parameters.AddWithValue("@neto2", null); }
                    try
                    {
                        SQLCommand.Parameters.AddWithValue("@importeNeto", Convert.ToDecimal(Datos.Rows[i]["importeNeto"].ToString()));
                    }catch { SQLCommand.Parameters.AddWithValue("@importeNeto", null); }
                    try
                    {
                        SQLCommand.Parameters.AddWithValue("@importeTotal", Convert.ToDecimal(Datos.Rows[i]["importeTotal"].ToString()));
                    }catch { SQLCommand.Parameters.AddWithValue("@importeTotal", null); }

                    try
                    {
                        DateTime Fecha = Convert.ToDateTime(Datos.Rows[i]["fechaPago"].ToString());
                        SQLCommand.Parameters.AddWithValue("@fechaPago", Fecha.ToString("yyyy-MM-dd"));
                    }
                    catch { SQLCommand.Parameters.AddWithValue("@fechaPago", null); };
                    try
                    {
                        SQLCommand.Parameters.AddWithValue("@id_convenio", Convert.ToInt32(Datos.Rows[i]["id_convenio"].ToString()));
                    }catch{SQLCommand.Parameters.AddWithValue("@id_convenio", 0);};

                    try
                    {
                        SQLCommand.Parameters.AddWithValue("@id_Tarifa", Convert.ToInt32(Datos.Rows[i]["tarifa"].ToString()));
                    }catch { SQLCommand.Parameters.AddWithValue("@id_Tarifa", 0); };

                    try
                    {
                        int pp = SQLCommand.ExecuteNonQuery();
                    }catch (Exception ex){DialogResult result = MessageBox.Show(ex.Message);}
                }
                // Oculta la barra de progreso
                pgbProgreso.Visible = false;
                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void ImportarDetalles()
        {
            if (chkLimpiarTablas.Checked)
            {
                Append_to_Log("Limpiando tabla facturas_detalles ... OK" + Environment.NewLine);
                MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE facturas_detalles;", _MySQLConnection);
                int p = cmd.ExecuteNonQuery();
            }

            try
            {
                //Creo el adaptador y selecciono los datos de la tabla
                OleDbDataAdapter adap = new OleDbDataAdapter("SELECT d.*,f.ivaRecargo as Importe21, f.recargo as Importe22, f.descuento as Importe23,  f.ivadescuento as Importe24, f.iva as Importe25 FROM Facturas f inner join detalles d on f.id_Factura=d.id_factura", _AccessConnection);

                //Creo el DataSet
                DataSet dsDatos = new DataSet();
                //Relleno el adaptador con los datos en memoria
                adap.Fill(dsDatos, "TblDetalles");
                //Creo el Datatable
                DataTable Datos = dsDatos.Tables["TblDetalles"];
                // Configura la barra de progreso
                pgbProgreso.Value = 0;
                pgbProgreso.Minimum = 0;
                pgbProgreso.Visible = true;
                pgbProgreso.Maximum = Datos.Rows.Count;

                Append_to_Log("Importando facturas ... ");
                int temp = this.txtDesde.Text == "" ? 0 : int.Parse(this.txtDesde.Text);
                int temp2 = this.txtHasta.Text == "" ? Datos.Rows.Count : int.Parse(this.txtHasta.Text);
                int i;
                for (i = temp; i < temp2; i++)
                {
                    pgbProgreso.Value += 1;    // Actualiza la barra de progreso
                    Application.DoEvents();    // Permite el redibujado del formulario
                    for (int j = 1; j <= 25; j++)
                    {
                        if (Datos.Rows[i]["Importe" + j.ToString()].ToString() != "0")
                        {
                            MySqlCommand SQLCommand = new MySqlCommand("INSERT INTO facturas_detalles (id_factura, " +
                            "id_concepto, importe, idOrden, idTipo) VALUES ( @id_factura, @id_concepto, " +
                            "@importe, @idOrden, @idTipo);", _MySQLConnection);
                            // Por cada uno de los importes generar un registro en detalles, agregar un registro
                            // para IVA, Recargos e IVARecargos
                            // Agregar el ID del item que corresponda al campo idTipo (por ejemplo: para IVA
                            // poner el código, para concepto particular poner el ID del concepto)
                            // Ordenar los items dentro de la factura
                            SQLCommand.Parameters.AddWithValue("@id_factura", Datos.Rows[i]["id_Factura"].ToString());
                            string concepto = j.ToString();
         
                            int orden = -1;
                            switch (j)
                            {
                                case 1:
                                    orden = 0;
                                    break;
                                case 2:
                                    orden = 2;
                                    break;
                                case 3:
                                    orden = 3;
                                    break;
                                case 4:
                                    orden = 4;
                                    break;
                                case 5:
                                    orden = 5;
                                    break;
                                case 6:
                                    orden = 6;
                                    break;
                                case 7:
                                    orden = 7;
                                    break;
                                case 8:
                                    orden = 1;
                                    break;
                                case 9:
                                    orden = 8;
                                    break;
                                case 10:
                                    orden = 9;
                                    break;
                                case 11:
                                    orden = 10;
                                    break;
                                case 12:
                                    orden = 11;
                                    break;
                                case 13:
                                    orden = 12;
                                    break;
                                case 14:
                                    orden = 13;
                                    break;
                                case 15:
                                    orden = 14;
                                    break;
                                case 16:
                                    orden = 15;
                                    break;
                                case 17:
                                    orden = 16;
                                    break;

                                case 21:
                                    concepto="18";
                                    orden = 18;
                                    break;
                                case 22:
                                    concepto="20";
                                    orden = 19;
                                    break;
                                case 23:
                                    concepto="21";
                                    orden = 20;
                                    break;
                                case 24:
                                    concepto="22";
                                    orden = 21;
                                    break;
                                case 25:
                                    concepto="23";
                                    orden = 17;
                                    break;
                                default:
                                    Console.WriteLine("Default case");
                                    break;
                            }

                            SQLCommand.Parameters.AddWithValue("@id_concepto",concepto);
                           
                            try
                            {
                                Decimal Valor = Convert.ToDecimal(Datos.Rows[i]["Importe" + j.ToString()].ToString());
                                SQLCommand.Parameters.AddWithValue("@importe", Valor);
                            }
                            catch
                            {
                                SQLCommand.Parameters.AddWithValue("@importe", 0); 
                            };
                            SQLCommand.Parameters.AddWithValue("@idOrden", orden);
                            SQLCommand.Parameters.AddWithValue("@idTipo", 0);
                            try
                            {
                                int p = SQLCommand.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                DialogResult result = MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                // Oculta la barra de progreso
                pgbProgreso.Visible = false;
                // Muestra el resultado del proceso
                Append_to_Log("OK" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Append_to_Log("Error!" + Environment.NewLine + ex.Message +
                    Environment.NewLine + ex.InnerException + Environment.NewLine +
                    "---------------------------------------" + Environment.NewLine);
            }
        }

        private void frmImportar_Load(object sender, EventArgs e)
        {
            this.txtHasta.Text = (1595531-1).ToString();
            this.txtDesde.Text = (1595531 - 500).ToString();
        }
    }
}
