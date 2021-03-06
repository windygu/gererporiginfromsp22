using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.businessrules;


namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripci�n breve de FrmImputaciones.
	/// </summary>
	public class FrmImputaciones : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList imglStandar;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbGuardar;
		protected Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uteTotalDestino;
		private System.Windows.Forms.Label label1;
		private Janus.Windows.GridEX.GridEX gridEXCompDestino;
		private mz.erp.ui.controls.mzComboEditor mzCEInstanciasCaja;
		private Infragistics.Win.Misc.UltraLabel ultraLabel4;
		private mz.erp.ui.controls.mzComboSearchEditor mzCmbCuenta;
		private Infragistics.Win.Misc.UltraLabel ultraLabel1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
		private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneTotalImputado;
		private System.Windows.Forms.Label label2;
		private Janus.Windows.GridEX.GridEX gridCompAImputar;
		private System.ComponentModel.IContainer components;


		#region C�digo generado por el Dise�ador de Windows Forms
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmImputaciones));
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uteTotalDestino = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label1 = new System.Windows.Forms.Label();
			this.gridEXCompDestino = new Janus.Windows.GridEX.GridEX();
			this.mzCEInstanciasCaja = new mz.erp.ui.controls.mzComboEditor();
			this.ultraLabel4 = new Infragistics.Win.Misc.UltraLabel();
			this.mzCmbCuenta = new mz.erp.ui.controls.mzComboSearchEditor();
			this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
			this.ultraExplorerBarContainerControl1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.uneTotalImputado = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
			this.label2 = new System.Windows.Forms.Label();
			this.gridCompAImputar = new Janus.Windows.GridEX.GridEX();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbGuardar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uteTotalDestino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEXCompDestino)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).BeginInit();
			this.ultraExplorerBarContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.uteTotalDestino);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.label1);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.gridEXCompDestino);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCEInstanciasCaja);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel4);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.mzCmbCuenta);
			this.ultraExplorerBarContainerControl5.Controls.Add(this.ultraLabel1);
			this.ultraExplorerBarContainerControl5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 40);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(854, 160);
			this.ultraExplorerBarContainerControl5.TabIndex = 6;
			// 
			// uteTotalDestino
			// 
			this.uteTotalDestino.Location = new System.Drawing.Point(728, 40);
			this.uteTotalDestino.Name = "uteTotalDestino";
			this.uteTotalDestino.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uteTotalDestino.ReadOnly = true;
			this.uteTotalDestino.Size = new System.Drawing.Size(120, 21);
			this.uteTotalDestino.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(728, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 16);
			this.label1.TabIndex = 38;
			this.label1.Text = "Total: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gridEXCompDestino
			// 
			this.gridEXCompDestino.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEXCompDestino.GroupByBoxVisible = false;
			this.gridEXCompDestino.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridEXCompDestino.Location = new System.Drawing.Point(0, 24);
			this.gridEXCompDestino.Name = "gridEXCompDestino";
			this.gridEXCompDestino.Size = new System.Drawing.Size(728, 128);
			this.gridEXCompDestino.TabIndex = 2;
			this.gridEXCompDestino.DoubleClick += new System.EventHandler(this.gridEXCompDestino_DoubleClick);
			// 
			// mzCEInstanciasCaja
			// 
			this.mzCEInstanciasCaja.AutoComplete = true;
			this.mzCEInstanciasCaja.DataSource = null;
			this.mzCEInstanciasCaja.DisplayMember = "";
			this.mzCEInstanciasCaja.DisplayMemberCaption = "";
			this.mzCEInstanciasCaja.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList;
			this.mzCEInstanciasCaja.Location = new System.Drawing.Point(120, 24);
			this.mzCEInstanciasCaja.MaxItemsDisplay = 7;
			this.mzCEInstanciasCaja.MoreItemsDisplayText = "(Ver mas elementos...)";
			this.mzCEInstanciasCaja.Name = "mzCEInstanciasCaja";
			this.mzCEInstanciasCaja.Size = new System.Drawing.Size(184, 21);
			this.mzCEInstanciasCaja.SorterMember = "";
			this.mzCEInstanciasCaja.TabIndex = 1;
			this.mzCEInstanciasCaja.ValueMember = "";
			this.mzCEInstanciasCaja.ValueMemberCaption = "";
			// 
			// ultraLabel4
			// 
			this.ultraLabel4.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel4.Location = new System.Drawing.Point(0, 24);
			this.ultraLabel4.Name = "ultraLabel4";
			this.ultraLabel4.Size = new System.Drawing.Size(120, 16);
			this.ultraLabel4.TabIndex = 36;
			this.ultraLabel4.Text = "Instancia de Caja";
			// 
			// mzCmbCuenta
			// 
			this.mzCmbCuenta.DataValue = "";
			this.mzCmbCuenta.EditObject = null;
			this.mzCmbCuenta.FastSearch = false;
			this.mzCmbCuenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.mzCmbCuenta.HierarchicalSearch = false;
			this.mzCmbCuenta.Location = new System.Drawing.Point(120, 0);
			this.mzCmbCuenta.Name = "mzCmbCuenta";
			this.mzCmbCuenta.ReadOnly = false;
			this.mzCmbCuenta.SearchObject = null;
			this.mzCmbCuenta.SearchObjectListener = null;
			this.mzCmbCuenta.Size = new System.Drawing.Size(464, 22);
			this.mzCmbCuenta.TabIndex = 0;
			this.mzCmbCuenta.ValueChanged += new System.EventHandler(this.mzCmbCuenta_ValueChanged);
			// 
			// ultraLabel1
			// 
			this.ultraLabel1.BackColor = System.Drawing.Color.Transparent;
			this.ultraLabel1.Location = new System.Drawing.Point(0, 3);
			this.ultraLabel1.Name = "ultraLabel1";
			this.ultraLabel1.Size = new System.Drawing.Size(62, 16);
			this.ultraLabel1.TabIndex = 25;
			this.ultraLabel1.Text = "Cuenta";
			// 
			// ultraExplorerBarContainerControl1
			// 
			this.ultraExplorerBarContainerControl1.Controls.Add(this.uneTotalImputado);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.label2);
			this.ultraExplorerBarContainerControl1.Controls.Add(this.gridCompAImputar);
			this.ultraExplorerBarContainerControl1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBarContainerControl1.Location = new System.Drawing.Point(28, 259);
			this.ultraExplorerBarContainerControl1.Name = "ultraExplorerBarContainerControl1";
			this.ultraExplorerBarContainerControl1.Size = new System.Drawing.Size(854, 144);
			this.ultraExplorerBarContainerControl1.TabIndex = 7;
			// 
			// uneTotalImputado
			// 
			this.uneTotalImputado.Location = new System.Drawing.Point(728, 16);
			this.uneTotalImputado.Name = "uneTotalImputado";
			this.uneTotalImputado.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Double;
			this.uneTotalImputado.ReadOnly = true;
			this.uneTotalImputado.Size = new System.Drawing.Size(120, 21);
			this.uneTotalImputado.TabIndex = 35;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(728, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 36;
			this.label2.Text = "Total: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gridCompAImputar
			// 
			this.gridCompAImputar.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridCompAImputar.GroupByBoxVisible = false;
			this.gridCompAImputar.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChanges;
			this.gridCompAImputar.Location = new System.Drawing.Point(3, 2);
			this.gridCompAImputar.Name = "gridCompAImputar";
			this.gridCompAImputar.Size = new System.Drawing.Size(725, 128);
			this.gridCompAImputar.TabIndex = 4;
			this.gridCompAImputar.DoubleClick += new System.EventHandler(this.gridCompAImputar_DoubleClick);
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbGuardar});
			this.toolBarStandar.ButtonSize = new System.Drawing.Size(65, 22);
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(920, 28);
			this.toolBarStandar.TabIndex = 20;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbGuardar
			// 
			this.tbbGuardar.ImageIndex = 4;
			this.tbbGuardar.Text = "Guardar";
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl1);
			this.ultraExplorerBar1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 160;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Informacion General";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl1;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 144;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Comprobantes A Imputar";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 � Tarea 983
			this.ultraExplorerBar1.Scrollbars = Infragistics.Win.UltraWinExplorerBar.ScrollbarStyle.Always;
			this.ultraExplorerBar1.Size = new System.Drawing.Size(920, 377);
			this.ultraExplorerBar1.TabIndex = 21;
			this.ultraExplorerBar1.TabStop = false;
			// 
			// FrmImputaciones
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 405);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmImputaciones";
			this.Text = "FrmImputaciones";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uteTotalDestino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEXCompDestino)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mzCEInstanciasCaja)).EndInit();
			this.ultraExplorerBarContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uneTotalImputado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridCompAImputar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private string _idCuenta;
		private ItemCuentaCorriente _itemCuentaCorriente;
		private string _processName;
		private CuentaCorriente _ctaCorriente;
		private string _origen = string.Empty;
		private businessrules.ImputarPagoCuentaCorriente _imputarPagoCtaCte = null;
		#endregion

		#region Constructores y Destructores

		public FrmImputaciones(string IdCuenta, ItemCuentaCorriente icc, string ProcessName, CuentaCorriente CtaCorriente)
		{
			InitializeComponent();
			_idCuenta = IdCuenta;
			_itemCuentaCorriente = icc;
			_processName = ProcessName;
			_ctaCorriente = CtaCorriente;
			Init();
		}

		public FrmImputaciones(string IdCuenta, ItemCuentaCorriente icc, string ProcessName, CuentaCorriente CtaCorriente, string Origen)
		{
			InitializeComponent();
			_idCuenta = IdCuenta;
			_itemCuentaCorriente = icc;
			_processName = ProcessName;
			_ctaCorriente = CtaCorriente;
			_origen = Origen;
			_imputarPagoCtaCte = new businessrules.ImputarPagoCuentaCorriente(this._origen, this._idCuenta);
			Init();
		}

		/// <summary>
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region Inicializadores y Carga
		
		private void Init()
		{
			Build_UI();
		}


		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}

		
		private void ConfigureInterface()
		{
			mzCmbCuenta.SearchObject = typeof( mz.erp.ui.forms.classes.tsa_Cuentas );
			
			gridCompAImputar.LayoutData = new mz.erp.ui.forms.classes.tsa_CuentaCorriente().GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota","FechaEmision", "FechaVencimiento","Numero", "Saldo","Signo","Pago"});
			gridEXCompDestino.LayoutData = new mz.erp.ui.forms.classes.tsa_CuentaCorriente().GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota","FechaEmision", "FechaVencimiento","Numero", "Saldo","Signo","Pago"});
			//gridCompAImputar.LayoutData = new Type.GeType( _imputarPagoCtaCte.TypeOfClass() ).GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota", "FechaVencimiento","Numero", "Saldo","Signo","Pago"});
			//gridEXCompDestino.LayoutData = new Type.GeType( _imputarPagoCtaCte.TypeOfClass() ).GetLayoutDetalleCuentaCorriente(new string [] {"IdComprobante", "Comprobante","Cuota", "FechaVencimiento","Numero", "Saldo","Signo","Pago"});

			Janus.Windows.GridEX.GridEXFormatCondition fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridCompAImputar.RootTable.Columns["Signo"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,
				0);
			fc.FormatStyle.ForeColor=System.Drawing.Color.Red;
			fc.TargetColumn = this.gridCompAImputar.RootTable.Columns["Saldo"];
			this.gridCompAImputar.RootTable.FormatConditions.Add(fc);
			

			fc = new Janus.Windows.GridEX.GridEXFormatCondition(this.gridEXCompDestino.RootTable.Columns["Signo"],
				Janus.Windows.GridEX.ConditionOperator.LessThan,
				0);
			fc.FormatStyle.ForeColor=System.Drawing.Color.Red;
			fc.TargetColumn = this.gridEXCompDestino.RootTable.Columns["Saldo"];
			this.gridEXCompDestino.RootTable.FormatConditions.Add(fc);

			mzCEInstanciasCaja.FillFromDataSource(mz.erp.businessrules.tfi_InstanciasCaja.GetList(Security.IdUsuario).Tables[0], "IdInstanciaCaja","Descripcion",8,"ID","Descripcion","Descripcion");
		
			//TODO sabri
			//_comprobante = Factory.GetComprobanteDePago();
		}

		private void InitializeData()
		{
			//mzCmbCuenta.DataValue = mz.erp.businessrules.tsa_Cuentas.GetByPk(_idCuenta).Codigo;
			mzCmbCuenta.DataValue = _imputarPagoCtaCte.GetByPk();
			mzCmbCuenta.ReadOnly = true;	

			if (gridEXCompDestino.RecordCount == 0)
				tbbGuardar.Enabled = false;
			else 
				tbbGuardar.Enabled = true;

		}

		private void InitEventHandlers()
		{
			this.toolBarStandar.ButtonClick +=new ToolBarButtonClickEventHandler(toolBarStandar_ButtonClick);

		}	
	
		private void InitDataBindings()
		{
		}

		#endregion

		#region Eventos y Delegados
		public event RowChanged OnRowChanged;
		public delegate void RowChanged( object sender, EventArgs args );
		#endregion

		#region M�todos Privados
		private void Save()
		{
			//TODO
			if(_ctaCorriente != null)
			{
				businessrules.comprobantes.ComprobanteDePago comprobante = ObtenerComprobanteDestino();
						
				if (comprobante != null)
				{
					if(comprobante.IsValidFor(Constantes.AplicacionDePagoAction))
						if(comprobante.AplicacionesDePagos != null)
						{		
							if(comprobante.CuentaCorriente.TotalPagoComprobantesSignoNegativo <= 0 || comprobante.CuentaCorriente.TotalPagoComprobantesSignoPositivo <= 0)
								MessageBox.Show("La imputacion no es valida. Ambos valores deben ser mayores a cero");
							else
								if(comprobante.CuentaCorriente.TotalPagoComprobantesSignoNegativo !=  comprobante.CuentaCorriente.TotalPagoComprobantesSignoPositivo)
								MessageBox.Show("La suma de los comprobantes a imputar debe ser igual a la suma de los comprobantes imputados");
								
							else
							{
								if(comprobante.CuentaCorriente.IsValidDetalleCuentaCorriente())
								{
									comprobante.AplicacionesDePagos.CommitWF();
									comprobante.ActualizaNumeracion = false;
									comprobante.Flush();
									Evaluate(comprobante);
								}
								else
									MessageBox.Show("Imputaci�n No V�lida.");
							}
						}
						else
							MessageBox.Show("Debe seleccionar los comprobantes que se imputan", "Advertencia", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
				}
			}
			else
				MessageBox.Show("Debe seleccionar un cliente", "Advertencia", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

		 
		}

		private businessrules.comprobantes.ComprobanteDePago ObtenerComprobanteDestino()
		{
			businessrules.comprobantes.ComprobanteDePago comprobante = null;
			foreach(Janus.Windows.GridEX.GridEXRow row in gridEXCompDestino.GetRows() )
			{
				ItemCuentaCorriente icc = (ItemCuentaCorriente) row.DataRow;
				if (icc.TotalPago > 0)
				{
					businessrules.comprobantes.CuentaCorriente ctaCorriente = businessrules.comprobantes.Factory.GetCuentaCorriente(_idCuenta, DateTime.MinValue, DateTime.MaxValue, null);
					ctaCorriente.GetDetalleComprobantesAImputar(_ctaCorriente.ComprobantesAImputar);
					ctaCorriente.TotalPagoComprobantesSignoNegativo = _ctaCorriente.TotalPagoComprobantesSignoNegativo;
					ctaCorriente.TotalPagoComprobantesSignoPositivo = _ctaCorriente.TotalPagoComprobantesSignoPositivo;
					comprobante = businessrules.comprobantes.Factory.GetComprobanteDePago(icc.IdComprobante,icc.Importe, icc.TotalPago, ctaCorriente);
				}
			}
			return comprobante;
		}

		protected void Evaluate(businessrules.comprobantes.ComprobanteDePago comprobante)
		{			
			bool hasErrors=false;
			foreach (System.Data.DataTable table in comprobante.DatasetComprobante.Tables)
				foreach (System.Data.DataRow row in table.Rows)
				{

					if (row.HasErrors)
					{
						hasErrors=true;
						/*20110328 - Tarea 0000057*/ FrmShowErrors _form = new /*20110328 - Tarea 0000057*/ FrmShowErrors(row);
						_form.Show();
						row.ClearErrors();
						
					}
					
				}
			if (hasErrors)comprobante.DatasetComprobante.RejectChanges();
			
			if (!hasErrors)
			{
				MessageBox.Show("La acci�n se ha ejecutado con �xito");
				if ( OnRowChanged != null )
				{
					OnRowChanged( this, null );
				}
				Close();
			}
		}

		private void ResetUI()
		{
			//TODO
			//_comprobante = Factory.GetComprobanteDePago();
			gridCompAImputar.SetDataBinding(null, null);
			gridEXCompDestino.SetDataBinding(null, null);
			gridCompAImputar.Refetch();
			gridEXCompDestino.Refetch();
		}

		private void ObtenerPago (Janus.Windows.GridEX.GridEX grilla)
		{
			if (grilla.SelectedItems.Count > 0)
			{
				ItemCuentaCorriente icc = (ItemCuentaCorriente) grilla.GetRow().DataRow;
				icc.Pago = Math.Abs(icc.Saldo);
				grilla.Refetch();
			}

		}

		#endregion

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			gridCompAImputar.UpdateData();
			gridEXCompDestino.UpdateData();
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					Save();
					break;
				default :
					break;
			}
		}

		private void mzCmbCuenta_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				
				if(mzCmbCuenta.DataValue != null && !mzCmbCuenta.DataValue.Equals(string.Empty))
				{
					string IdCuenta= mz.erp.businessrules.tsa_Cuentas.GetPkByUk((string) mzCmbCuenta.DataValue);
					//string IdCuenta2 = _imputarPagoCtaCte.IdCuenta;
					//if(_comprobante.CuentaCorriente == null || _comprobante.CuentaCorriente.IdCuenta != IdCuenta)
					//{
					
						_ctaCorriente.GetDetalleComprobantesAImputar(_processName);
					    _ctaCorriente.TotalPagoComprobantesSignoNegativoChanged +=new EventHandler(_ctaCorriente_TotalPagoComprobantesSignoNegativoChanged);
					    _ctaCorriente.TotalPagoComprobantesSignoPositivoChanged +=new EventHandler(_ctaCorriente_TotalPagoComprobantesSignoPositivoChanged);
					    uteTotalDestino.Value = _ctaCorriente.TotalPagoComprobantesSignoPositivo;
					    uneTotalImputado.Value = _ctaCorriente.TotalPagoComprobantesSignoNegativo;
					    //uteTotalDestino.DataBindings.Add("Value",_ctaCorriente,"TotalPagoComprobantesSignoPositivo");
						//uneTotalImputado.DataBindings.Add("Value",_ctaCorriente,"TotalPagoComprobantesSignoNegativo");

			
						//Es un recibo o nota de credito que se recibio como parametro,por ende no se deben buscar comprobantes destinos pues
						//ya ha sido seleccionado previamente, solo hay que mostrar los comprobantes origen (facturas, notas de debitos) contra los
						//cual imputar dicho comprobante destino
					//TODO sabri lo de parametrizado
						//if(_parametrizado)
						//{
							if (_itemCuentaCorriente.Signo == 1)
							{
								gridCompAImputar.SetDataBinding(_ctaCorriente.ComprobantesAImputar, null);		
								gridCompAImputar.RootTable.Columns["Comprobante"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridCompAImputar.RootTable.Columns["FechaVencimiento"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridCompAImputar.RootTable.Columns["FechaEmision"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridCompAImputar.RootTable.Columns["Numero"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridCompAImputar.RootTable.Columns["Saldo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								Janus.Windows.GridEX.GridEXFilterCondition filter1= new Janus.Windows.GridEX.GridEXFilterCondition();
								filter1.Column=gridCompAImputar.RootTable.Columns["Signo"];
								filter1.ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal;
								filter1.Value1 = -1;
								gridCompAImputar.RootTable.ApplyFilter(filter1);
								gridEXCompDestino.SetDataBinding(_ctaCorriente.ComprobantesAImputar, null);
								gridEXCompDestino.RootTable.Columns["Comprobante"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridEXCompDestino.RootTable.Columns["FechaVencimiento"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridEXCompDestino.RootTable.Columns["FechaEmision"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridEXCompDestino.RootTable.Columns["Numero"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridEXCompDestino.RootTable.Columns["Saldo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								Janus.Windows.GridEX.GridEXFilterCondition filter= new Janus.Windows.GridEX.GridEXFilterCondition();
								filter.Column=gridEXCompDestino.RootTable.Columns["IdComprobante"];
								filter.ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal;
								filter.Value1 = _itemCuentaCorriente.IdComprobante;
								gridEXCompDestino.RootTable.ApplyFilter(filter);
				

							}
							else
								//Es una factura o nota de debito que se recibio como parametro,por ende no se deben buscar comprobantes origen pues
								//ya ha sido seleccionado previamente, sloo hay que mostrar los comprobatens destino (recibos, notas de creditos) contra los
								//cual imputar dicho comprobante origen
								if(_itemCuentaCorriente.Signo == -1)
							{
								gridEXCompDestino.SetDataBinding(_ctaCorriente.ComprobantesAImputar, null);
								gridEXCompDestino.RootTable.Columns["Comprobante"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridEXCompDestino.RootTable.Columns["FechaVencimiento"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridEXCompDestino.RootTable.Columns["Numero"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridEXCompDestino.RootTable.Columns["Saldo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								Janus.Windows.GridEX.GridEXFilterCondition filter= new Janus.Windows.GridEX.GridEXFilterCondition();
								filter.Column=gridEXCompDestino.RootTable.Columns["Signo"];
								filter.ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal;
								filter.Value1 = 1;
								gridEXCompDestino.RootTable.ApplyFilter(filter);
								gridCompAImputar.SetDataBinding(_ctaCorriente.ComprobantesAImputar, null);		
								gridCompAImputar.RootTable.Columns["Comprobante"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridCompAImputar.RootTable.Columns["FechaVencimiento"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridCompAImputar.RootTable.Columns["Numero"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								gridCompAImputar.RootTable.Columns["Saldo"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
								Janus.Windows.GridEX.GridEXFilterCondition filter1= new Janus.Windows.GridEX.GridEXFilterCondition();
								filter1.Column=gridCompAImputar.RootTable.Columns["IdComprobante"];
								filter1.ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal;
								filter1.Value1 = _itemCuentaCorriente.IdComprobante;
								gridCompAImputar.RootTable.ApplyFilter(filter1);


							}
						/*}
							//_parametrizado == false, por ende no se ha seleccionado ningun comprobante al cual aplicarle una imputacion
							// se deben mostrar todos los comprobantes que puedan imputarse
						else
						{

										
							gridCompAImputar.SetDataBinding(_comprobante.CuentaCorriente.Detalle, null);		
							gridCompAImputar.RootTable.Columns["Comprobante"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridCompAImputar.RootTable.Columns["FechaVencimiento"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridCompAImputar.RootTable.Columns["Numero"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridCompAImputar.RootTable.Columns["SaldoSinSigno"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridEXCompDestino.SetDataBinding(_comprobante.CuentaCorriente.Detalle, null);
							gridEXCompDestino.RootTable.Columns["Comprobante"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridEXCompDestino.RootTable.Columns["FechaVencimiento"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridEXCompDestino.RootTable.Columns["Numero"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							gridEXCompDestino.RootTable.Columns["SaldoSinSigno"].EditType=Janus.Windows.GridEX.EditType.NoEdit;
							Janus.Windows.GridEX.GridEXFilterCondition filter= new Janus.Windows.GridEX.GridEXFilterCondition();
							filter.Column=gridEXCompDestino.RootTable.Columns["Signo"];
							filter.ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal;
							filter.Value1 = 1;
				
							gridEXCompDestino.RootTable.ApplyFilter(filter);
							Janus.Windows.GridEX.GridEXFilterCondition filter1= new Janus.Windows.GridEX.GridEXFilterCondition();
							filter1.Column=gridCompAImputar.RootTable.Columns["Signo"];
							filter1.ConditionOperator = Janus.Windows.GridEX.ConditionOperator.Equal;
							filter1.Value1 = -1;
				
							gridCompAImputar.RootTable.ApplyFilter(filter1);
						}*/

					}

				//}
			
				else
				{
					ResetUI();
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);;
			}
		
		}

		private void gridEXCompDestino_DoubleClick(object sender, System.EventArgs e)
		{
			if ( gridEXCompDestino.RecordCount > 0 )
				this.ObtenerPago(gridEXCompDestino);
		}


		private void gridCompAImputar_DoubleClick(object sender, System.EventArgs e)
		{
			if ( gridCompAImputar.RecordCount > 0 )
                this.ObtenerPago(gridCompAImputar);
		}

		private void _ctaCorriente_TotalPagoComprobantesSignoNegativoChanged(object sender, EventArgs e)
		{
			uneTotalImputado.Value = _ctaCorriente.TotalPagoComprobantesSignoNegativo;
		}

		private void _ctaCorriente_TotalPagoComprobantesSignoPositivoChanged(object sender, EventArgs e)
		{
			uteTotalDestino.Value = _ctaCorriente.TotalPagoComprobantesSignoPositivo;
		}
	}
}
