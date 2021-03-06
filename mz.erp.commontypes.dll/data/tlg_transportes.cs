﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace mz.erp.commontypes.data {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class tlg_TransportesDataset : DataSet {
        
        private tlg_TransportesDataTable tabletlg_Transportes;
        
        public tlg_TransportesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_TransportesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_Transportes"] != null)) {
                    this.Tables.Add(new tlg_TransportesDataTable(ds.Tables["tlg_Transportes"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public tlg_TransportesDataTable tlg_Transportes {
            get {
                return this.tabletlg_Transportes;
            }
        }
        
        public override DataSet Clone() {
            tlg_TransportesDataset cln = ((tlg_TransportesDataset)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["tlg_Transportes"] != null)) {
                this.Tables.Add(new tlg_TransportesDataTable(ds.Tables["tlg_Transportes"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tabletlg_Transportes = ((tlg_TransportesDataTable)(this.Tables["tlg_Transportes"]));
            if ((this.tabletlg_Transportes != null)) {
                this.tabletlg_Transportes.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_TransportesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_transportes.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_Transportes = new tlg_TransportesDataTable();
            this.Tables.Add(this.tabletlg_Transportes);
        }
        
        private bool ShouldSerializetlg_Transportes() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_TransportesRowChangeEventHandler(object sender, tlg_TransportesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_TransportesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTransporte;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnIdResponsable;
            
            private DataColumn columnIdProveedor;
            
            private DataColumn columnValor1;
            
            private DataColumn columnValor2;
            
            private DataColumn columnValor3;
            
            private DataColumn columnFormulaDeCalculo;
            
            private DataColumn columnIdConexion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnObservaciones;
            
            internal tlg_TransportesDataTable() : 
                    base("tlg_Transportes") {
                this.InitClass();
            }
            
            internal tlg_TransportesDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdTransporteColumn {
                get {
                    return this.columnIdTransporte;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn IdResponsableColumn {
                get {
                    return this.columnIdResponsable;
                }
            }
            
            internal DataColumn IdProveedorColumn {
                get {
                    return this.columnIdProveedor;
                }
            }
            
            internal DataColumn Valor1Column {
                get {
                    return this.columnValor1;
                }
            }
            
            internal DataColumn Valor2Column {
                get {
                    return this.columnValor2;
                }
            }
            
            internal DataColumn Valor3Column {
                get {
                    return this.columnValor3;
                }
            }
            
            internal DataColumn FormulaDeCalculoColumn {
                get {
                    return this.columnFormulaDeCalculo;
                }
            }
            
            internal DataColumn IdConexionColumn {
                get {
                    return this.columnIdConexion;
                }
            }
            
            internal DataColumn FechaCreacionColumn {
                get {
                    return this.columnFechaCreacion;
                }
            }
            
            internal DataColumn IdConexionCreacionColumn {
                get {
                    return this.columnIdConexionCreacion;
                }
            }
            
            internal DataColumn UltimaModificacionColumn {
                get {
                    return this.columnUltimaModificacion;
                }
            }
            
            internal DataColumn IdConexionUltimaModificacionColumn {
                get {
                    return this.columnIdConexionUltimaModificacion;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn ObservacionesColumn {
                get {
                    return this.columnObservaciones;
                }
            }
            
            public tlg_TransportesRow this[int index] {
                get {
                    return ((tlg_TransportesRow)(this.Rows[index]));
                }
            }
            
            public event tlg_TransportesRowChangeEventHandler tlg_TransportesRowChanged;
            
            public event tlg_TransportesRowChangeEventHandler tlg_TransportesRowChanging;
            
            public event tlg_TransportesRowChangeEventHandler tlg_TransportesRowDeleted;
            
            public event tlg_TransportesRowChangeEventHandler tlg_TransportesRowDeleting;
            
            public void Addtlg_TransportesRow(tlg_TransportesRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_TransportesRow Addtlg_TransportesRow(string IdTransporte, string Descripcion, string IdResponsable, string IdProveedor, string Valor1, string Valor2, string Valor3, string FormulaDeCalculo, long IdConexion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, string Observaciones) {
                tlg_TransportesRow rowtlg_TransportesRow = ((tlg_TransportesRow)(this.NewRow()));
                rowtlg_TransportesRow.ItemArray = new object[] {
                        IdTransporte,
                        Descripcion,
                        IdResponsable,
                        IdProveedor,
                        Valor1,
                        Valor2,
                        Valor3,
                        FormulaDeCalculo,
                        IdConexion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        Observaciones};
                this.Rows.Add(rowtlg_TransportesRow);
                return rowtlg_TransportesRow;
            }
            
            public tlg_TransportesRow FindByIdTransporte(string IdTransporte) {
                return ((tlg_TransportesRow)(this.Rows.Find(new object[] {
                            IdTransporte})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_TransportesDataTable cln = ((tlg_TransportesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_TransportesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTransporte = this.Columns["IdTransporte"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnIdResponsable = this.Columns["IdResponsable"];
                this.columnIdProveedor = this.Columns["IdProveedor"];
                this.columnValor1 = this.Columns["Valor1"];
                this.columnValor2 = this.Columns["Valor2"];
                this.columnValor3 = this.Columns["Valor3"];
                this.columnFormulaDeCalculo = this.Columns["FormulaDeCalculo"];
                this.columnIdConexion = this.Columns["IdConexion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnObservaciones = this.Columns["Observaciones"];
            }
            
            private void InitClass() {
                this.columnIdTransporte = new DataColumn("IdTransporte", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTransporte);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnIdResponsable = new DataColumn("IdResponsable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdResponsable);
                this.columnIdProveedor = new DataColumn("IdProveedor", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProveedor);
                this.columnValor1 = new DataColumn("Valor1", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor1);
                this.columnValor2 = new DataColumn("Valor2", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor2);
                this.columnValor3 = new DataColumn("Valor3", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor3);
                this.columnFormulaDeCalculo = new DataColumn("FormulaDeCalculo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFormulaDeCalculo);
                this.columnIdConexion = new DataColumn("IdConexion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexion);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnObservaciones = new DataColumn("Observaciones", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnObservaciones);
                this.Constraints.Add(new UniqueConstraint("tlg_transportesKey1", new DataColumn[] {
                                this.columnIdTransporte}, true));
                this.columnIdTransporte.AllowDBNull = false;
                this.columnIdTransporte.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_TransportesRow Newtlg_TransportesRow() {
                return ((tlg_TransportesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_TransportesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_TransportesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_TransportesRowChanged != null)) {
                    this.tlg_TransportesRowChanged(this, new tlg_TransportesRowChangeEvent(((tlg_TransportesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_TransportesRowChanging != null)) {
                    this.tlg_TransportesRowChanging(this, new tlg_TransportesRowChangeEvent(((tlg_TransportesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_TransportesRowDeleted != null)) {
                    this.tlg_TransportesRowDeleted(this, new tlg_TransportesRowChangeEvent(((tlg_TransportesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_TransportesRowDeleting != null)) {
                    this.tlg_TransportesRowDeleting(this, new tlg_TransportesRowChangeEvent(((tlg_TransportesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_TransportesRow(tlg_TransportesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_TransportesRow : DataRow {
            
            private tlg_TransportesDataTable tabletlg_Transportes;
            
            internal tlg_TransportesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_Transportes = ((tlg_TransportesDataTable)(this.Table));
            }
            
            public string IdTransporte {
                get {
                    return ((string)(this[this.tabletlg_Transportes.IdTransporteColumn]));
                }
                set {
                    this[this.tabletlg_Transportes.IdTransporteColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletlg_Transportes.DescripcionColumn]));
                }
                set {
                    this[this.tabletlg_Transportes.DescripcionColumn] = value;
                }
            }
            
            public string IdResponsable {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Transportes.IdResponsableColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.IdResponsableColumn] = value;
                }
            }
            
            public string IdProveedor {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Transportes.IdProveedorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.IdProveedorColumn] = value;
                }
            }
            
            public string Valor1 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Transportes.Valor1Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.Valor1Column] = value;
                }
            }
            
            public string Valor2 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Transportes.Valor2Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.Valor2Column] = value;
                }
            }
            
            public string Valor3 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Transportes.Valor3Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.Valor3Column] = value;
                }
            }
            
            public string FormulaDeCalculo {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Transportes.FormulaDeCalculoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.FormulaDeCalculoColumn] = value;
                }
            }
            
            public long IdConexion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Transportes.IdConexionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.IdConexionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tabletlg_Transportes.FechaCreacionColumn]));
                }
                set {
                    this[this.tabletlg_Transportes.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tabletlg_Transportes.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tabletlg_Transportes.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_Transportes.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Transportes.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_Transportes.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.RowIdColumn] = value;
                }
            }
            
            public string Observaciones {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Transportes.ObservacionesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Transportes.ObservacionesColumn] = value;
                }
            }
            
            public bool IsIdResponsableNull() {
                return this.IsNull(this.tabletlg_Transportes.IdResponsableColumn);
            }
            
            public void SetIdResponsableNull() {
                this[this.tabletlg_Transportes.IdResponsableColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdProveedorNull() {
                return this.IsNull(this.tabletlg_Transportes.IdProveedorColumn);
            }
            
            public void SetIdProveedorNull() {
                this[this.tabletlg_Transportes.IdProveedorColumn] = System.Convert.DBNull;
            }
            
            public bool IsValor1Null() {
                return this.IsNull(this.tabletlg_Transportes.Valor1Column);
            }
            
            public void SetValor1Null() {
                this[this.tabletlg_Transportes.Valor1Column] = System.Convert.DBNull;
            }
            
            public bool IsValor2Null() {
                return this.IsNull(this.tabletlg_Transportes.Valor2Column);
            }
            
            public void SetValor2Null() {
                this[this.tabletlg_Transportes.Valor2Column] = System.Convert.DBNull;
            }
            
            public bool IsValor3Null() {
                return this.IsNull(this.tabletlg_Transportes.Valor3Column);
            }
            
            public void SetValor3Null() {
                this[this.tabletlg_Transportes.Valor3Column] = System.Convert.DBNull;
            }
            
            public bool IsFormulaDeCalculoNull() {
                return this.IsNull(this.tabletlg_Transportes.FormulaDeCalculoColumn);
            }
            
            public void SetFormulaDeCalculoNull() {
                this[this.tabletlg_Transportes.FormulaDeCalculoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionNull() {
                return this.IsNull(this.tabletlg_Transportes.IdConexionColumn);
            }
            
            public void SetIdConexionNull() {
                this[this.tabletlg_Transportes.IdConexionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_Transportes.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_Transportes.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_Transportes.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_Transportes.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_Transportes.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_Transportes.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsObservacionesNull() {
                return this.IsNull(this.tabletlg_Transportes.ObservacionesColumn);
            }
            
            public void SetObservacionesNull() {
                this[this.tabletlg_Transportes.ObservacionesColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_TransportesRowChangeEvent : EventArgs {
            
            private tlg_TransportesRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_TransportesRowChangeEvent(tlg_TransportesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_TransportesRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}
