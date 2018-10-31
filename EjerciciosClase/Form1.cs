using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;
using System.Data.SqlClient;


namespace EjerciciosClase
{
    public partial class Form1 : Form
    {
        Provincias objprovincias=new Provincias();
        Barrios objbarrios=new Barrios();
        Sexo objsexo=new Sexo();
        CuotasSociales objcuota = new CuotasSociales();
        Socio objsocio = new Socio();

        public negprovincias objnegProv = new negprovincias();
        public negbarrios objnegBarrios = new negbarrios();
        public negsexo objnegsexo = new negsexo();
        public negcuotasocial objnegcuotasocial = new negcuotasocial();
        public negsocios objnegsocios = new negsocios();
        public int ok;
        public int lol;



        public Form1()
        {
            InitializeComponent();
            LlenarDGV2();
            LlenarDGVProv();
            LlenarSex();
            LlenarCuota();
            LlenoComboCuota();
            LlenarSocios();
            LlenoCombosexx();
            LlenoComboBarr();
            Cargocomboo();


        }

        #region PestañaProvincia
        private void btguardar_Click(object sender, EventArgs e)
        {

            int nGrabados = -1;
            TxtBox_a_Obj();

            nGrabados = objnegProv.abmProvincias("Agregar", objprovincias);

            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lblMensaje.Text = " No pudo grabar provincias en el sistema";
            }
            else
            {
                lblMensaje.Text = "Se grabo con exito provincias";

                Limpiar();

            }
            LlenarDGVProv();
            LlenoComboCuota();
            Cargocomboo();


        }

        private void btcambiar_Click(object sender, EventArgs e)
        {
           
            int nGrabados = -1;
            TxtBox_a_Obj();

            nGrabados = objnegProv.abmProvincias("Modificar", objprovincias);

            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lblMensaje.Text = " No pudo grabar provincias en el sistema";
            }
            else
            {
                lblMensaje.Text = "Se Modifico con exito provincias";

                Limpiar();

            }
            LlenarDGVProv();
            comboprov.Text = string.Empty;
            Cargocomboo();
        }


        private void bteliminar_Click(object sender, EventArgs e)
        {
            ControloBarrios();

            if (ok==1)
            {
                int nGrabados = -1;
                TxtBox_a_Obj();

                nGrabados = objnegProv.abmProvincias("Eliminar", objprovincias);

                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
                }

                if (nGrabados == -1)
                {
                    lblMensaje.Text = " No pudo grabar provincias en el sistema";
                }
                else
                {
                    lblMensaje.Text = "Se Elimino con exito provincias   " + txtnombre.Text;

                    Limpiar();

                }
                LlenarDGVProv();
                comboprov.Text = string.Empty;
                
                Cargocomboo();
            }
            else if (ok==3)
            {
                int nGrabados = -1;
                TxtBox_a_Obj();

                nGrabados = objnegProv.abmProvincias("Eliminar", objprovincias);

                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
                }

                if (nGrabados == -1)
                {
                    lblMensaje.Text = " No pudo grabar provincias en el sistema";
                }
                else
                {
                    lblMensaje.Text = "Se Elimino con exito provincias   " + txtnombre.Text;

                    Limpiar();

                }
                LlenarDGVProv();
                comboprov.Text = string.Empty;
                Cargocomboo();
            }
            

            
        }
      
        
        #endregion


        #region PestañaBarrio
        private void btnguardar_Click_1(object sender, EventArgs e)
        {
           
            int nGrabados = -1;
            TxtBox_a_ObjBarrio();

            nGrabados = objnegBarrios.abmBarrios("Agregar", objbarrios,objprovincias);

            if (txbarriocod.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lberror.Text = " No pudo grabar Barrios en el sistema";
            }
            else
            {
                lberror.Text = "Se grabo con exito Barrios";
                LimpiarBarrio();
            }
            LlenarDGV2();
            LlenoComboBarr();


        }

       
        private void btmodificar_Click(object sender, EventArgs e)
        {
           
            int nGrabados = -1;
            TxtBox_a_ObjBarrio();

            nGrabados = objnegBarrios.abmBarrios("Modificar", objbarrios,objprovincias);

            if (txbarriocod.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lberror.Text = " No pudo grabar Barrios en el sistema";
            }
            else
            {
                lberror.Text = "Se Modifico con exito Barrios";
                LimpiarBarrio();
            }
            LlenarDGV2();
        }


        private void btborrar_Click(object sender, EventArgs e)
        {
            ControloSocios();
            if (lol==1)
            {
                int nGrabados = -1;
                TxtBox_a_ObjBarrio();

                nGrabados = objnegBarrios.abmBarrios("Eliminar", objbarrios,objprovincias);

                if (txbarriocod.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
                }

                if (nGrabados == -1)
                {
                    lberror.Text = " No pudo grabar Barrios en el sistema";
                }
                else
                {
                    lberror.Text = "Se Elimino con exito Barrio   " + txbarriocod.Text;
                    LimpiarBarrio();
                }
                LlenarDGV2();
            }
            else if (lol!=1)
            {
                int nGrabados = -1;
                TxtBox_a_ObjBarrio();

                nGrabados = objnegBarrios.abmBarrios("Eliminar", objbarrios,objprovincias);

                if (txbarriocod.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
                }

                if (nGrabados == -1)
                {
                    lberror.Text = " No pudo grabar Barrios en el sistema";
                }
                else
                {
                    lberror.Text = "Se Elimino con exito Barrio   " + txbarriocod.Text;
                    LimpiarBarrio();
                }
                LlenarDGV2();
            }
           
        }

        #endregion

      
        
        #region PestañaSexo
        private void butguardar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_Objsexo();

            nGrabados = objnegsexo.abmSexo("Agregar", objsexo);

            if (txtcodigosexo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lbinfo.Text = " No pudo grabar Sexo en el sistema";
            }
            else
            {
                lbinfo.Text = "Se grabo con exito Sexo";

                LimpiarSex();

            }
            LlenarSex();
            LlenoCombosexx();

        }

        private void butmodificar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_Objsexo();

            nGrabados = objnegsexo.abmSexo("Modificar", objsexo);

            if (txtcodigosexo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lbinfo.Text = " No pudo Modificar Sexo en el sistema";
            }
            else
            {
                lbinfo.Text = "Se Modifico con exito Sexo";

                LimpiarSex();

            }
            LlenarSex();

        }

        private void butborrar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_Objsexo();

            nGrabados = objnegsexo.abmSexo("Eliminar", objsexo);

            if (txtcodigosexo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lbinfo.Text = " No pudo Eliminar Sexo en el sistema";
            }
            else
            {
                lbinfo.Text = "Se Elimino con exito Sexo";

                LimpiarSex();

            }
            LlenarSex();
        }



        #endregion



        #region PestañaCuotaSocial
        private void btguarcuota_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_ObjCuota();

            nGrabados = objnegcuotasocial.abmCuotas("Agregar", objcuota);

            if (combocuota.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lbcuotainfo.Text = " No pudo grabar Cuotas en el sistema";
            }
            else
            {
                lbcuotainfo.Text = "Se grabo con exito en Cuota Social";

                LimpiarCuota();

            }
            LlenarCuota();
        }
        private void btmodifcuota_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_ObjCuota();

            nGrabados = objnegcuotasocial.abmCuotas("Modificar", objcuota);

            if (combocuota.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lbcuotainfo.Text = " No pudo grabar Cuotas en el sistema";
            }
            else
            {
                lbcuotainfo.Text = "Se grabo con exito en Cuota Social";

                LimpiarCuota();

            }
            LlenarCuota();
        }
        private void btelimcuota_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_ObjCuota();

            nGrabados = objnegcuotasocial.abmCuotas("Eliminar", objcuota);

            if (combocuota.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lbcuotainfo.Text = " No pudo grabar Cuotas en el sistema";
            }
            else
            {
                lbcuotainfo.Text = "Se grabo con exito en Cuota Social";

                LimpiarCuota();

            }
            LlenarCuota();
        }
        #endregion


        #region PestañaSocios
        private void btguardosocio_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_ObjSocio();

            nGrabados = objnegsocios.abmSocios("Agregar", objsocio);

            if (txtcodigosexo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo por favor", "ERROR");
            }

            if (nGrabados == -1)
            {
                lbsocios.Text = " No pudo grabar Socios en el sistema";
            }
            else
            {
                lbsocios.Text = "Se grabo con exito Socios";

                LimpiarSocios();

            }
        }
        #endregion


        #region Metodos

        //Metodos Provincia
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtnombre.Text = string.Empty;
        }
        private void LlenarDGVProv()
        {


            DataTable dsprov = new DataTable();
            dsprov = objnegProv.listadoProvincias("Todos");
            datagridprov.DataSource = dsprov;
            


        }
        public  int ControloBarrios()
        {
             
            DataTable p = new DataTable();
            p = objnegProv.ControloBarrios("Todos");
            
            
            foreach (DataRow fila in p.Rows)
            {
               
                string valor = fila["prov_cod"].ToString();
                
                if (txtCodigo.Text == valor.ToString())
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede borrar esta provincia porque tiene barrios en ella");
                    Limpiar();
                   //("No es Recomendable borrar esta Provincia" +
                   //    " porque tiene barrios asociados. Borrar igual?", 
                   //    "Control" ,MessageBoxButtons.YesNo);

                    //if (dialogResult == DialogResult.Yes)
                    //{
                    //    int nGrabados = -1;
                    //    TxtBox_a_Obj();

                    //    nGrabados = objnegBarrios.borrobarr("Pepe", objbarrios, objprovincias);
                    //    LlenarDGV2();
                    //    ok = 1;
                    //}
                    //else if (dialogResult == DialogResult.No)
                    //{
                    //    ok = 2;
                    //    Limpiar();
                    //}
                }

                else if (txtCodigo.Text!= valor.ToString())
                {
                    ok = 3;
                   
                }
               

            }
          return  ok;
        }
        private void Cargocomboo()
        {
            comboprov.DataSource = objnegProv.CargoCombo2();
            comboprov.ValueMember = "_CodProvincia";
            comboprov.DisplayMember = "_Nombre";

        }
        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            objprovincias._CodProvincia = Convert.ToChar(txtCodigo.Text);
            objprovincias._Nombre = txtnombre.Text;
        }
        private void ds_a_textboxProv(DataTable ds)
        {
           
            txtCodigo.Text = ds.Rows[0]["prov_cod"].ToString();
            txtnombre.Text = ds.Rows[0]["prov_nombre"].ToString();
            
        }
        private void datagridprov_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridprov.CurrentRow.Cells[0].Value==DBNull.Value)
            {

            }
            else if (datagridprov.CurrentRow.Cells[0].Value!=DBNull.Value)
            {
                DataTable ds = new DataTable();


                objprovincias._CodProvincia = Convert.ToChar(datagridprov.CurrentRow.Cells[0].Value);

                ds = objnegProv.listadoProvincias(objprovincias._CodProvincia.ToString());

                ds_a_textboxProv(ds);
            }
            
            

        }
       

        //Metodos Barrio
        private void LlenarDGV2()
        {


            DataTable dsbarrio = new DataTable();
            dsbarrio = objnegBarrios.listadobarrios("Todos");
            datagridbarrio.DataSource = dsbarrio;


        }
        private void TxtBox_a_ObjBarrio() //Prepara el objeto a enviar a la capa de Negocio
        {
            objbarrios._Nombre = txtbarrio.Text;
            objbarrios._CodBarrio = Convert.ToChar(txbarriocod.Text);
            objbarrios._CodProvincia = System.Convert.ToChar(comboprov.SelectedValue);
            
           

        }
        private void LimpiarBarrio()
        {
            txbarriocod.Text = string.Empty;
            txtbarrio.Text = string.Empty;
            
        }
        private void datagridbarrio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridbarrio.CurrentRow.Cells[0].Value==DBNull.Value)
            {

            }
            else if (datagridbarrio.CurrentRow.Cells[0].Value!=DBNull.Value)
            {
                DataTable ds = new DataTable();

                objbarrios._CodBarrio = Convert.ToChar(datagridbarrio.CurrentRow.Cells[0].Value);

                ds = objnegBarrios.listadobarrios(objbarrios._CodBarrio.ToString());

                ds_a_textboxBarrio(ds);
            }
            
        }
        private void ds_a_textboxBarrio(DataTable ds)
        {
            txbarriocod.Text = ds.Rows[0]["barr_cod"].ToString();
            txtbarrio.Text = ds.Rows[0]["barr_nombre"].ToString();
            

        }
        public int ControloSocios()
        {

            DataTable j = new DataTable();
            j = objnegBarrios.ControloSocios("Todos");


            foreach (DataRow fila in j.Rows)
            {

                string valor = fila["barr_cod"].ToString();

                if (txbarriocod.Text == valor.ToString())
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede borrar este barrio porque hay socios que" +
                        "viven en él");
                    LimpiarBarrio();
                    //    ("No es Recomendable borrar este barrio" +
                    //    " porque tiene socios asociados. Borrar igual?",
                    //    "Control", MessageBoxButtons.YesNo);

                    //if (dialogResult == DialogResult.Yes)
                    //{
                    //    int nGrabados = -1;
                    //    TxtBox_a_ObjBarrio();

                    //    nGrabados = objnegsocios.borrosocio("Pepe", objsocio, objbarrios);
                    //    LlenarSocios();
                    //    lol = 1;
                    //}
                    //else if (dialogResult == DialogResult.No)
                    //{
                    //    lol = 2;
                    //    LimpiarBarrio();
                    //}
                }

                else if (txbarriocod.Text != valor.ToString())
                {
                    lol = 3;

                }

            }
            
        
            return lol;
        }


            //Metodos Sexo
        private void LlenarSex()
        {
            DataTable dssexo = new DataTable();
            dssexo = objnegsexo.listadoSexos("Todos");
            datagridsexo.DataSource = dssexo;
        }
        private void TxtBox_a_Objsexo()
        {
            objsexo._Descripcion = txsex.Text;
            objsexo._CodSexo = Convert.ToChar(txtcodigosexo.Text);
        }
        private void LimpiarSex()
        {
            txsex.Text = string.Empty;
            txtcodigosexo.Text = string.Empty;
        }
        private void datagridsexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridsexo.CurrentRow.Cells[0].Value==DBNull.Value)
            {

            }
            else if (datagridsexo.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                DataTable ds = new DataTable();

                objsexo._CodSexo = Convert.ToChar(datagridsexo.CurrentRow.Cells[0].Value);

                ds = objnegsexo.listadoSexos(objsexo._CodSexo.ToString());

                ds_a_textboxSexo(ds);
            }
           
        }
        private void ds_a_textboxSexo(DataTable ds)
        {
            txtcodigosexo.Text = ds.Rows[0]["sexo_cod"].ToString();
            txsex.Text = ds.Rows[0]["sexo"].ToString();

        }

        //Metodos Cuota Social

        private void LlenarCuota()
        {
            DataTable dscuota = new DataTable();
            dscuota = objnegcuotasocial.listadoCuotas("Todos");
            datagridcuotaSocial.DataSource = dscuota;
        }
        private void TxtBox_a_ObjCuota()
        {
            objcuota._CodSocio = Convert.ToString(combocuota.Text);
            objcuota._Anio = Convert.ToString(txCuotaanio.Text);
            objcuota._Mes = Convert.ToChar(txCuotames.Text);
            objcuota._MontoCuota = Convert.ToDecimal(txMonto_Cuota.Text);
            objcuota._Pagada = Convert.ToChar(txCuotaPagada.Text);
        }
        private void LimpiarCuota()
        {
            combocuota.Text = string.Empty;
            txCuotaanio.Text = string.Empty;
            txCuotames.Text = string.Empty;
            txMonto_Cuota.Text = string.Empty;
            txCuotaPagada.Text = string.Empty;
        }
        private void datagridcuotaSocial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridcuotaSocial.CurrentRow.Cells[0].Value==DBNull.Value)
            {

            }
            else if (datagridcuotaSocial.CurrentRow.Cells[0].Value!=DBNull.Value)
            {
                DataTable ds = new DataTable();

                objcuota._CodSocio = Convert.ToString(datagridcuotaSocial.CurrentRow.Cells[0].Value);

                ds = objnegcuotasocial.listadoCuotas(objcuota._CodSocio.ToString());

                ds_a_textboxcuota(ds);
            }    
           
        }
        private void ds_a_textboxcuota(DataTable ds)
        {
            combocuota.Text = ds.Rows[0]["socio_cod"].ToString();
            txCuotaanio.Text = ds.Rows[0]["anio"].ToString();
            txCuotames.Text = ds.Rows[0]["mes"].ToString();
            txMonto_Cuota.Text = ds.Rows[0]["monto_cuota"].ToString();
            txCuotaPagada.Text = ds.Rows[0]["pagada"].ToString();
        }
        private void LlenoComboCuota()
        {
            DataSet c = new DataSet();
            c = objnegcuotasocial.CargoCuota("Todos");
            combocuota.DataSource = c.Tables[0].DefaultView;
            combocuota.ValueMember = "socio_cod";
        }


        //Metodos Socios

        private void LlenarSocios()
        {
            DataTable dsSocios = new DataTable();
            dsSocios = objnegsocios.listadosocios("Todos");
            datagridsocios.DataSource = dsSocios;
        }
        private void LimpiarSocios()
        {
            txactivo.Text = string.Empty;
            txCodsocio.Text = string.Empty;
            txnombre.Text = string.Empty;
            txapellido.Text = string.Empty;
            combosexocod.Text = string.Empty;
            txdomicilio.Text = string.Empty;
            combobarrCodigo.Text = string.Empty;
            txmontomes.Text = string.Empty;
            txalta.Text = string.Empty;
            txbaja.Text = string.Empty;


        }
        private void TxtBox_a_ObjSocio()
        {
            objsocio._CodSocio = Convert.ToString(txCodsocio.Text);
            objsocio._Nombre = txnombre.Text;
            objsocio._Apellido = txapellido.Text;
            objsocio._CodSexo = Convert.ToChar(combosexocod.Text);
            objsocio._Domicilio = txdomicilio.Text;
            objsocio._CodBarrio = Convert.ToChar(combobarrCodigo.Text);
            objsocio._MontoMes = Convert.ToDecimal(txmontomes.Text);
            objsocio._FechaAlta = Convert.ToDecimal(txalta.Text);
            objsocio._FechaBaja = Convert.ToDecimal(txbaja.Text);
            objsocio._Activo = Convert.ToChar(txactivo.Text);
        }
        private void datagridsocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridsocios.CurrentRow.Cells[0].Value==DBNull.Value)
            {

            }
            else if (datagridsocios.CurrentRow.Cells[0].Value != DBNull.Value)
            {
                DataTable ds = new DataTable();

                objsocio._CodSocio = Convert.ToString(datagridsocios.CurrentRow.Cells[0].Value);

                ds = objnegsocios.listadosocios(objsocio._CodSocio.ToString());

                ds_a_textboxsocio(ds);
            }
           
        }
        private void ds_a_textboxsocio(DataTable ds)
        {
            txCodsocio.Text = ds.Rows[0]["socio_cod"].ToString();
            txnombre.Text = ds.Rows[0]["nombre"].ToString();
            txapellido.Text = ds.Rows[0]["apellido"].ToString();
            combosexocod.Text = ds.Rows[0]["sexo_cod"].ToString();
            txdomicilio.Text = ds.Rows[0]["domicilio"].ToString();
            combobarrCodigo.Text = ds.Rows[0]["barr_cod"].ToString();
            txmontomes.Text = ds.Rows[0]["monto_mes"].ToString();
            txalta.Text = ds.Rows[0]["fecha_alta"].ToString();
            txbaja.Text = ds.Rows[0]["fecha_baja"].ToString();
            txactivo.Text = ds.Rows[0]["activo"].ToString();
        }
        private void LlenoCombosexx()
        {
            DataSet c = new DataSet();
            c = objnegsocios.LlenoCombosexx("Todos");
            combosexocod.DataSource = c.Tables[0].DefaultView;
            combosexocod.ValueMember = "sexo_cod";
        }
       
        private void LlenoComboBarr()
        {
            DataSet f = new DataSet();
            f = objnegsocios.LlenoComboBarr("Todos");
            combobarrCodigo.DataSource = f.Tables[0].DefaultView;
            combobarrCodigo.ValueMember = "barr_cod";
        }






        #endregion

        
    }
}
