﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
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
    public class tsa_AgrupCuentasDataset : DataSet {
        
        private tsa_AgrupCuentasDataTable tabletsa_AgrupCuentas;
        
        public tsa_AgrupCuentasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsa_AgrupCuentasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsa_AgrupCuentas"] != null)) {
                    this.Tables.Add(new tsa_AgrupCuentasDataTable(ds.Tables["tsa_AgrupCuentas"]));
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
        public tsa_AgrupCuentasDataTable tsa_AgrupCuentas {
            get {
                return this.tabletsa_AgrupCuentas;
            }
        }
        
        public override DataSet Clone() {
            tsa_AgrupCuentasDataset cln = ((tsa_AgrupCuentasDataset)(base.Clone()));
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
            if ((ds.Tables["tsa_AgrupCuentas"] != null)) {
                this.Tables.Add(new tsa_AgrupCuentasDataTable(ds.Tables["tsa_AgrupCuentas"]));
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
            this.tabletsa_AgrupCuentas = ((tsa_AgrupCuentasDataTable)(this.Tables["tsa_AgrupCuentas"]));
            if ((this.tabletsa_AgrupCuentas != null)) {
                this.tabletsa_AgrupCuentas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsa_AgrupCuentasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsa_AgrupCuentas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsa_AgrupCuentas = new tsa_AgrupCuentasDataTable();
            this.Tables.Add(this.tabletsa_AgrupCuentas);
        }
        
        private bool ShouldSerializetsa_AgrupCuentas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsa_AgrupCuentasRowChangeEventHandler(object sender, tsa_AgrupCuentasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_AgrupCuentasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdAgrupamiento;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnIdTipoAgrup;
            
            private DataColumn columnIdPadre;
            
            private DataColumn columnJerarquia;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tsa_AgrupCuentasDataTable() : 
                    base("tsa_AgrupCuentas") {
                this.InitClass();
            }
            
            internal tsa_AgrupCuentasDataTable(DataTable table) : 
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
            
            internal DataColumn IdAgrupamientoColumn {
                get {
                    return this.columnIdAgrupamiento;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn IdTipoAgrupColumn {
                get {
                    return this.columnIdTipoAgrup;
                }
            }
            
            internal DataColumn IdPadreColumn {
                get {
                    return this.columnIdPadre;
                }
            }
            
            internal DataColumn JerarquiaColumn {
                get {
                    return this.columnJerarquia;
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
            
            internal DataColumn IdReservadoColumn {
                get {
                    return this.columnIdReservado;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            public tsa_AgrupCuentasRow this[int index] {
                get {
                    return ((tsa_AgrupCuentasRow)(this.Rows[index]));
                }
            }
            
            public event tsa_AgrupCuentasRowChangeEventHandler tsa_AgrupCuentasRowChanged;
            
            public event tsa_AgrupCuentasRowChangeEventHandler tsa_AgrupCuentasRowChanging;
            
            public event tsa_AgrupCuentasRowChangeEventHandler tsa_AgrupCuentasRowDeleted;
            
            public event tsa_AgrupCuentasRowChangeEventHandler tsa_AgrupCuentasRowDeleting;
            
            public void Addtsa_AgrupCuentasRow(tsa_AgrupCuentasRow row) {
                this.Rows.Add(row);
            }
            
            public tsa_AgrupCuentasRow Addtsa_AgrupCuentasRow(long IdAgrupamiento, string Descripcion, long IdTipoAgrup, long IdPadre, string Jerarquia, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tsa_AgrupCuentasRow rowtsa_AgrupCuentasRow = ((tsa_AgrupCuentasRow)(this.NewRow()));
                rowtsa_AgrupCuentasRow.ItemArray = new object[] {
                        IdAgrupamiento,
                        Descripcion,
                        IdTipoAgrup,
                        IdPadre,
                        Jerarquia,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtsa_AgrupCuentasRow);
                return rowtsa_AgrupCuentasRow;
            }
            
            public tsa_AgrupCuentasRow FindByIdAgrupamiento(long IdAgrupamiento) {
                return ((tsa_AgrupCuentasRow)(this.Rows.Find(new object[] {
                            IdAgrupamiento})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsa_AgrupCuentasDataTable cln = ((tsa_AgrupCuentasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsa_AgrupCuentasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdAgrupamiento = this.Columns["IdAgrupamiento"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnIdTipoAgrup = this.Columns["IdTipoAgrup"];
                this.columnIdPadre = this.Columns["IdPadre"];
                this.columnJerarquia = this.Columns["Jerarquia"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdAgrupamiento = new DataColumn("IdAgrupamiento", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdAgrupamiento);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnIdTipoAgrup = new DataColumn("IdTipoAgrup", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoAgrup);
                this.columnIdPadre = new DataColumn("IdPadre", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPadre);
                this.columnJerarquia = new DataColumn("Jerarquia", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnJerarquia);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.Constraints.Add(new UniqueConstraint("tsa_AgrupCuentasKey1", new DataColumn[] {
                                this.columnIdAgrupamiento}, true));
                this.columnIdAgrupamiento.AllowDBNull = false;
                this.columnIdAgrupamiento.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsa_AgrupCuentasRow Newtsa_AgrupCuentasRow() {
                return ((tsa_AgrupCuentasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsa_AgrupCuentasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsa_AgrupCuentasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsa_AgrupCuentasRowChanged != null)) {
                    this.tsa_AgrupCuentasRowChanged(this, new tsa_AgrupCuentasRowChangeEvent(((tsa_AgrupCuentasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsa_AgrupCuentasRowChanging != null)) {
                    this.tsa_AgrupCuentasRowChanging(this, new tsa_AgrupCuentasRowChangeEvent(((tsa_AgrupCuentasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsa_AgrupCuentasRowDeleted != null)) {
                    this.tsa_AgrupCuentasRowDeleted(this, new tsa_AgrupCuentasRowChangeEvent(((tsa_AgrupCuentasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsa_AgrupCuentasRowDeleting != null)) {
                    this.tsa_AgrupCuentasRowDeleting(this, new tsa_AgrupCuentasRowChangeEvent(((tsa_AgrupCuentasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsa_AgrupCuentasRow(tsa_AgrupCuentasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_AgrupCuentasRow : DataRow {
            
            private tsa_AgrupCuentasDataTable tabletsa_AgrupCuentas;
            
            internal tsa_AgrupCuentasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsa_AgrupCuentas = ((tsa_AgrupCuentasDataTable)(this.Table));
            }
            
            public long IdAgrupamiento {
                get {
                    return ((long)(this[this.tabletsa_AgrupCuentas.IdAgrupamientoColumn]));
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdAgrupamientoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletsa_AgrupCuentas.DescripcionColumn]));
                }
                set {
                    this[this.tabletsa_AgrupCuentas.DescripcionColumn] = value;
                }
            }
            
            public long IdTipoAgrup {
                get {
                    try {
                        return ((long)(this[this.tabletsa_AgrupCuentas.IdTipoAgrupColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdTipoAgrupColumn] = value;
                }
            }
            
            public long IdPadre {
                get {
                    try {
                        return ((long)(this[this.tabletsa_AgrupCuentas.IdPadreColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdPadreColumn] = value;
                }
            }
            
            public string Jerarquia {
                get {
                    try {
                        return ((string)(this[this.tabletsa_AgrupCuentas.JerarquiaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.JerarquiaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsa_AgrupCuentas.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_AgrupCuentas.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsa_AgrupCuentas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_AgrupCuentas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsa_AgrupCuentas.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsa_AgrupCuentas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsa_AgrupCuentas.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsa_AgrupCuentas.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_AgrupCuentas.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsIdTipoAgrupNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.IdTipoAgrupColumn);
            }
            
            public void SetIdTipoAgrupNull() {
                this[this.tabletsa_AgrupCuentas.IdTipoAgrupColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdPadreNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.IdPadreColumn);
            }
            
            public void SetIdPadreNull() {
                this[this.tabletsa_AgrupCuentas.IdPadreColumn] = System.Convert.DBNull;
            }
            
            public bool IsJerarquiaNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.JerarquiaColumn);
            }
            
            public void SetJerarquiaNull() {
                this[this.tabletsa_AgrupCuentas.JerarquiaColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsa_AgrupCuentas.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsa_AgrupCuentas.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsa_AgrupCuentas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsa_AgrupCuentas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsa_AgrupCuentas.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsa_AgrupCuentas.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsa_AgrupCuentas.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsa_AgrupCuentas.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsa_AgrupCuentas.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_AgrupCuentasRowChangeEvent : EventArgs {
            
            private tsa_AgrupCuentasRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsa_AgrupCuentasRowChangeEvent(tsa_AgrupCuentasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsa_AgrupCuentasRow Row {
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
