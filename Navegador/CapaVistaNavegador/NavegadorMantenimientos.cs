using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorNavegador;


namespace CapaVistaNavegador
{
    public partial class NavegadorMantenimientos : UserControl
    {
        //Variables Globales
        TextBox[] campos; int estado = 0;
        string tablas; string DB;
        public string campoEstado = ""; public string tablaAyuda = "";
        public string campoAyuda = ""; public string idAplicacion = "";
        string usuario = "", idusuario = "";
        //LLAMADA A FUNCION DE PERMISOS
        //public reporte formReporte = new reporte();

        DataGridView dataE;
        Controlador control = new Controlador(); Control controles;
        //Estas variables permiten actualizar los datos de las combobox
        ArrayList referencia0 = new ArrayList();
        ArrayList referencia1 = new ArrayList();
        ArrayList referencia2 = new ArrayList();
        ArrayList referencia3 = new ArrayList();
        ArrayList referencia4 = new ArrayList();
        //Permisos 
        public Boolean permisoIngreso = true;  //Valor que debe llegar de seguridad
        public Boolean permisoModificar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoEliminar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoConsultar = true;  //Valor que debe llegar de seguridad
        public Boolean permisoReporteador = true;  //Valor que debe llegar de seguridad

        public string permisos;
        //public string usuario = "";
        public string aplicacion = "";
        //public string idusuario;
        public string idmodulo;
        public NavegadorMantenimientos()
        {
            InitializeComponent();
            
            //bloquearBtn(btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnInicio, btnAnterior, btnSiguiente, btnFinal, btnAyuda, btnSalir, idusuario, usuario);
        }

        public TextBox[] ClasificaTextboxsegunParent(Control parent)
        {
            try
            {
                controles = parent;
            }
            catch
            {

            }
            return control.ordenandoTextos(parent);
        }
        public void ObtenerCamposdeTabla(TextBox[] alias, string tabla, string BD)
        {
            try
            {
                control.comparaTagscampoBD(alias, tabla, BD);
                campos = alias;
                tablas = tabla;
                DB = BD;
            }
            catch
            {

            }
        }
        public void MetodoSalirVista(Form menu)
        {
            try
            {
                control.funAsignarSalidadControl(menu);
            }
            catch
            {

            }
        }
        public void LlenarCombobox(ComboBox cbx, string tabla, string value, string display, string estatus)
        {
            try
            {
                referencia1.Add(tabla);
                referencia2.Add(value);
                referencia3.Add(display);
                referencia4.Add(estatus);
                referencia0.Add(cbx);
                control.metodoLlenarCombo(cbx, tabla, value, display, estatus);
            }
            catch
            {

            }
        }
        public void SelecciondeFilaDGV(DataGridView data)
        {
            try
            {
                dataE = data;
                control.SeleccionDeFilaDGV(data);
            }
            catch
            {

            }
        }
        public void ActivaRadiobtn(RadioButton activo, RadioButton inactivo, TextBox estatus)
        {
            try
            {
                control.activaRadiobtn(activo, inactivo, estatus);
            }
            catch
            {

            }
        }
        public void CambioEstadoTextbox(TextBox estado, RadioButton AI, string cadenaEstado)
        {
            try
            {
                control.CambioEstadoTextBox(estado, AI, cadenaEstado);
            }
            catch
            {

            }
        }
        public void EnviarDatoComboaTextbox(ComboBox combo, TextBox combotexto)
        {
            try
            {
                control.enviarDatoCbxaTextbox(combo, combotexto);
            }
            catch
            {

            }
        }
        public void SeleccionarElementosenCombo(ComboBox combo, TextBox combotexto)
        {
            try
            {
                control.SeleccionarElementoEnComboBox(combo, combotexto);
            }
            catch
            {

            }
        }               
        public void CambiarFormatoFecha(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                control.CambiarFormatoFecha(date, textoDate);
            }
            catch
            {

            }
        }        
        public void SeleccionarFechaDTP(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                control.SeleccionarFechaDTP(date, textoDate);
            }
            catch
            {

            }
        }
        private void ActualizarCombobox()
        {
            try
            {
                for (int i = 0; i < referencia0.Count; i++)
                {

                    control.metodoLlenarCombo((ComboBox)referencia0[i], (string)referencia1[i], (string)referencia2[i], (string)referencia3[i], (string)referencia4[i]);
                }
            }
            catch
            {

            }
        }
        private void DesactivarBotones(int tipo)
        {
            try
            {
                if (tipo == 0)
                {
                    //activa
                    //Función de Validar Permisos, Liam Patrick Bernard Garcia, 0901-18-10092
                    if (permisoIngreso == false)
                    {
                        btnIngresar.Enabled = false;
                    }
                    else
                    {
                        btnIngresar.Enabled = true;
                    }

                    if (permisoModificar == false)
                    {
                        btnEditar.Enabled = false;
                    }
                    else
                    {
                        btnEditar.Enabled = true;
                    }

                    if (permisoEliminar == false)
                    {
                        btnEliminar.Enabled = false;
                    }
                    else
                    {
                        btnEliminar.Enabled = true;
                    }

                    if (permisoConsultar == false)
                    {
                       // btnConsultar.Enabled = false;
                    }
                    else
                    {
                     //   btnConsultar.Enabled = true;
                    }

                    if (permisoReporteador == false)
                    {
                     //   btnReporte.Enabled = false;
                    }
                    else
                    {
                     //   btnReporte.Enabled = true;
                    }

                    btnActualizar.Enabled = true;
                    //desactiva
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                }
                else
                {
                    //desactiva
                    btnIngresar.Enabled = false;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    //btnConsultar.Enabled = false;
                    //btnReporte.Enabled = false;
                    btnActualizar.Enabled = false;
                    //activa
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
            }
            catch
            {

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)//Jaime López 0901-18-735
        {
            try
            {
                estado = 0;
                DesactivarBotones(0);
                ManipularEstadodeElementosVista(0);
            }
            catch
            {

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Metodos de ingresar y eliminar adaptados por Melissa Aldana, al boton guardar
                switch (estado)
                {
                    case 1://Ingresar
                        bool resultadoI;
                        resultadoI = control.insertarDatostabla(campos, tablas);
                        if (resultadoI == true)
                        {
                            MessageBox.Show("El ingreso se a realizado con éxito!");
                        }
                        else
                        {
                            MessageBox.Show("El ingreso no se realizó con éxito!");
                        }
                        break;
                    case 2://Modificar de Wilber Enrique Segura Ramirez 0901-18-13952
                        bool resultado;//Varaible para saber si se ejecutó con éxito la sentencia SQL
                        resultado = control.modificar(campos, tablas);
                        if (resultado == true)
                        {
                            MessageBox.Show("Modificación realizada con éxito!");
                        }
                        else
                        {
                            MessageBox.Show("Modificación no se realizó con éxito!");
                        }
                        break;
                    case 3://Eliminar
                        control.InhabilitarRegistro(campos, tablas, campoEstado);
                        break;
                    case 0://Error alguno de los otros casos no hizo su trabajo
                        MessageBox.Show("Error, no ha seleccionado ninguna función para guardar sus acciones");
                        break;
                }
                estado = 0;
                DesactivarBotones(0);
                ManipularEstadodeElementosVista(0);
                LlenarTabla();//recarga los datos de la tabla
            }
            catch
            {

            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int entero = control.idSiguienteDeNuevoIngreso(tablas);
                int cantidadCampos = campos.Length;
                campos[0].Text = entero.ToString();
                foreach (Control ctr in controles.Controls)
                {
                    if (ctr is TextBox)
                    {
                        if (ctr.Tag.ToString() == campos[0].Tag.ToString())
                        {
                            ctr.Enabled = false;
                        }
                        else
                        {
                            ctr.Enabled = true;
                        }
                    }
                    if (ctr is ComboBox)
                    {
                        ctr.Enabled = true;
                    }
                    if (ctr is DateTimePicker)
                    {
                        ctr.Enabled = true;
                    }
                    if (ctr is RadioButton)
                    {
                        ctr.Enabled = true;
                    }
                }
                estado = 1;
                DesactivarBotones(1);
                ManipularEstadodeElementosVista(1);
            }
            catch
            {

            }
        }
        private void btnModificar_Click(object sender, EventArgs e)//Boton de modificar campos dinámico
        {
            try
            {
                if (dvgConsulta != null)
                {
                    if (dvgConsulta.RowCount - 1 > 0)
                    {
                        ManipularEstadodeElementosVista(3);

                        estado = 2;
                        DesactivarBotones(1);
                    }
                    else
                    {
                        MessageBox.Show("No tiene Registros");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("No existe ninguna datagridview");
                    return;
                }        
            }
            catch
            {

            }
        }

        /*Brayan Mauricio Cifuentes López - 9959-18-11113*/
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                control.InhabilitarRegistro(campos, tablas, campoEstado);
                estado = 3;
                DesactivarBotones(0);
                ManipularEstadodeElementosVista(0);
                LlenarTabla();   
            }
            catch
            {

            }
        }
        //boton de verificacion para navegacion sin registros
        public Boolean VerificarContenidodeTabla()
        {//Kevin Rolando González Ramírez 0901-18-1387
            try
            {

            }
            catch
            {

            }
            if (dvgConsulta.RowCount - 1 > 0)

                return true;
            else
                return false;
        }
        DataGridView dvgConsulta;
        //funcion para pedir datagridView
        public void ObtenerNombreDGV(DataGridView tabla)
        {
            try
            {
                dvgConsulta = tabla;
            }
            catch
            {

            }
        }
        public void LlenarTabla() //Jaime López 0901-18-735
        {
            try
            {
                DataTable dt = control.ActualizarDGV(tablas);
                //dvgConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvgConsulta.DataSource = dt;
            }
            catch
            {

            }
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }
                //obtengo el indicie actual
                int actual = dvgConsulta.CurrentCell.RowIndex;
                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 
                int numFilas = dvgConsulta.RowCount;            
                if (actual == numFilas - 2)
                {
                    dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];
                }
                else
                {
                    var arList = new ArrayList();//todos los campos a obtener de la tabla
                    dvgConsulta.CurrentCell = dvgConsulta.Rows[actual + 1].Cells[0];
                    //for para guardar todos los datos de la columnas
                    for (int i = 0; i < numColumnas; i++)
                    {
                        string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                        arList.Add(col);//vamos guardando todos los campos
                    }
                }
                ContabilizarCamposenBD();
            }
            catch
            {

            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }
                //obtengo el indicie actual
                int actual = dvgConsulta.CurrentCell.RowIndex;
                //hacer un condicional para ver si no es el primer campo
                if (actual == 0)
                {
                    // MessageBox.Show("Lo siento no puede retroceder mas esta en el primer campo");
                    dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];
                }
                else
                {
                    dvgConsulta.CurrentCell = dvgConsulta.Rows[actual - 1].Cells[0];
                    var arList = new ArrayList();//todos los campos a obtener de la tabla
                    int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 
                    //for para guardar todos los datos de la columnas
                    for (int i = 0; i < numColumnas; i++)
                    {
                        string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                        arList.Add(col);//va guardando todos los campos
                    }
                }
                ContabilizarCamposenBD();            
            }
            catch
            {

            }
        }
        private void btnInicio_Click(object sender, EventArgs e)//Kevin Rolando González Ramírez 0901-18-1387
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }
                dvgConsulta.CurrentCell = dvgConsulta.Rows[0].Cells[0];
                var arList = new ArrayList();//todos los campos a obtener de la tabla
                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 
                //for para guardar todos los datos de la columnas
                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);//va guardando todos los campos
                }
                ContabilizarCamposenBD();
            }
            catch
            {

            }
        }
        private void btnFinal_Click(object sender, EventArgs e)
        {
            try
            {
                //verificacion de la existencia de registros
                if (VerificarContenidodeTabla() == false)
                {
                    MessageBox.Show("No tiene registros actualmente, no se puede navegar");
                    return;
                }
                dvgConsulta.CurrentCell = dvgConsulta.Rows[dvgConsulta.RowCount - 2].Cells[0];
                var arList = new ArrayList();//todos los campos a obtener de la tabla
                int numColumnas = dvgConsulta.ColumnCount;//cuenta cuantos columnas 
                for (int i = 0; i < numColumnas; i++)
                {
                    string col = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                    arList.Add(col);
                }
                ContabilizarCamposenBD();
            }
            catch
            {

            }
        }
        private void navegador_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //falta actu de combos
                for (int i = 0; i < campos.Length; i++)
                {
                    campos[i].Text = "";
                }
                ActualizarCombobox();               
            }
            catch
            {

            }
            LlenarTabla();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Realmente desea salir?", "Salir",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    generic.Close();
                }
                catch
                {

                }
            }
            else { }          
            
        }
        Form generic;
        public void ObtenerReferenciaFormActual(Form generico)
        {
            try
            {
                generic = generico;
            }
            catch
            {

            }
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            try
            {
                control.LlamadaAyudas(idAplicacion, campoAyuda, tablaAyuda);             
            }
            catch
            {

            }
        }
        private void ManipularEstadodeElementosVista(int modo)
        {
            try
            {
                int cantidadCampos = campos.Length;
                if (modo == 0)
                {
                    foreach (Control ctr in controles.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            ctr.Enabled = false;
                            ctr.Text = "";
                        }
                        if (ctr is ComboBox)
                        {
                            ctr.Enabled = false;
                            ctr.Text = "";
                        }
                        if (ctr is DateTimePicker)
                        {
                            ctr.Enabled = false;
                        }
                        if (ctr is RadioButton)
                        {
                            ctr.Enabled = false;
                        }
                        if (ctr is DataGridView)
                        {
                            ctr.Enabled = true;
                        }
                    }
                }
                if (modo == 1 || modo == 3)
                {
                    foreach (Control ctr in controles.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            if (ctr.Tag.ToString() == campos[0].Tag.ToString())
                            {
                                ctr.Enabled = false;
                            }
                            else
                            {
                                ctr.Enabled = true;
                                if (modo == 1)
                                {
                                    ctr.Text = "";
                                }
                            }
                        }
                        if (ctr is ComboBox)
                        {
                            ctr.Enabled = true;
                        }
                        if (ctr is DateTimePicker)
                        {
                            ctr.Enabled = true;
                            if (modo == 1)
                            {
                                ((DateTimePicker)ctr).Value = DateTime.Now;
                            }
                        }
                        if (ctr is RadioButton)
                        {
                            ctr.Enabled = true;
                            if (modo == 1)
                            {
                                ((RadioButton)ctr).Checked = false;
                            }
                        }
                        if (ctr is DataGridView)
                        {
                            ctr.Enabled = false;
                        }
                    }
                }
            }
            catch
            {

            }
        }
        public void ContabilizarCamposenBD()
        {
            try
            {
                int cantidadCampos = dvgConsulta.Columns.Count;

                for (int i = 0; i < cantidadCampos; i++)
                {
                    campos[i].Text = dvgConsulta.CurrentRow.Cells[i].Value.ToString();
                }
            }
            catch
            {

            }
        }       
        public void Obtenerayuda(string idAplicacion, string campoAyuda, string tablaAyuda)
        {
            try
            {
                control.LlamadaAyudas(idAplicacion, campoAyuda, tablaAyuda);                                
            }
            catch
            {

            }
        }
        public void RecibeHora(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                control.metodoRecibeHora(date, textoDate);
            }
            catch
            {

            }
        }
        public void ColocaHora(DateTimePicker date, TextBox textoDate)
        {
            try
            {
                control.metodoColocaHora(date, textoDate);
            }
            catch
            {

            }
        }

		private void btnAyuda_Click_1(object sender, EventArgs e)
		{
            try
            {
                Help.ShowHelp(this, "C:/AYUDAGH/AYUDA.chm", "C:/AYUDAGH/AYUDA.html");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

		public void bloquearBtn(string tipousuario)
        {
            //MessageBox.Show(id_usuario + " " + usuario);
            control.bloquearBtn(btnIngresar, btnEditar, btnGuardar, btnCancelar, btnEliminar, btnImprimir, btnActualizar, btnInicio, btnAnterior, btnSiguiente, btnFinal, btnAyuda, btnSalir, tipousuario);
        }

    }
}
