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
    public class tlg_RemitoDataset : DataSet {
        
        private tlg_RemitoDataTable tabletlg_Remito;
        
        public tlg_RemitoDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_RemitoDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_Remito"] != null)) {
                    this.Tables.Add(new tlg_RemitoDataTable(ds.Tables["tlg_Remito"]));
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
        public tlg_RemitoDataTable tlg_Remito {
            get {
                return this.tabletlg_Remito;
            }
        }
        
        public override DataSet Clone() {
            tlg_RemitoDataset cln = ((tlg_RemitoDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_Remito"] != null)) {
                this.Tables.Add(new tlg_RemitoDataTable(ds.Tables["tlg_Remito"]));
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
            this.tabletlg_Remito = ((tlg_RemitoDataTable)(this.Tables["tlg_Remito"]));
            if ((this.tabletlg_Remito != null)) {
                this.tabletlg_Remito.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_RemitoDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_Remito.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_Remito = new tlg_RemitoDataTable();
            this.Tables.Add(this.tabletlg_Remito);
        }
        
        private bool ShouldSerializetlg_Remito() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_RemitoRowChangeEventHandler(object sender, tlg_RemitoRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_RemitoDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdRemito;
            
            private DataColumn columnFecha;
            
            private DataColumn columnTipo;
            
            private DataColumn columnNumero;
            
            private DataColumn columnIdCuenta;
            
            private DataColumn columnIdEstado;
            
            private DataColumn columnConservaPreico;
            
            private DataColumn columnIdCondicionDeVenta;
            
            private DataColumn columnComentario;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tlg_RemitoDataTable() : 
                    base("tlg_Remito") {
                this.InitClass();
            }
            
            internal tlg_RemitoDataTable(DataTable table) : 
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
            
            internal DataColumn IdRemitoColumn {
                get {
                    return this.columnIdRemito;
                }
            }
            
            internal DataColumn FechaColumn {
                get {
                    return this.columnFecha;
                }
            }
            
            internal DataColumn TipoColumn {
                get {
                    return this.columnTipo;
                }
            }
            
            internal DataColumn NumeroColumn {
                get {
                    return this.columnNumero;
                }
            }
            
            internal DataColumn IdCuentaColumn {
                get {
                    return this.columnIdCuenta;
                }
            }
            
            internal DataColumn IdEstadoColumn {
                get {
                    return this.columnIdEstado;
                }
            }
            
            internal DataColumn ConservaPreicoColumn {
                get {
                    return this.columnConservaPreico;
                }
            }
            
            internal DataColumn IdCondicionDeVentaColumn {
                get {
                    return this.columnIdCondicionDeVenta;
                }
            }
            
            internal DataColumn ComentarioColumn {
                get {
                    return this.columnComentario;
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
            
            public tlg_RemitoRow this[int index] {
                get {
                    return ((tlg_RemitoRow)(this.Rows[index]));
                }
            }
            
            public event tlg_RemitoRowChangeEventHandler tlg_RemitoRowChanged;
            
            public event tlg_RemitoRowChangeEventHandler tlg_RemitoRowChanging;
            
            public event tlg_RemitoRowChangeEventHandler tlg_RemitoRowDeleted;
            
            public event tlg_RemitoRowChangeEventHandler tlg_RemitoRowDeleting;
            
            public void Addtlg_RemitoRow(tlg_RemitoRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_RemitoRow Addtlg_RemitoRow(
                        long IdRemito, 
                        System.DateTime Fecha, 
                        string Tipo, 
                        string Numero, 
                        string IdCuenta, 
                        long IdEstado, 
                        bool ConservaPreico, 
                        long IdCondicionDeVenta, 
                        string Comentario, 
                        System.DateTime FechaCreacion, 
                        long IdConexionCreacion, 
                        System.Byte[] UltimaModificacion, 
                        long IdConexionUltimaModificacion, 
                        long IdReservado, 
                        System.Guid RowId, 
                        long IdSucursal, 
                        long IdEmpresa) {
                tlg_RemitoRow rowtlg_RemitoRow = ((tlg_RemitoRow)(this.NewRow()));
                rowtlg_RemitoRow.ItemArray = new object[] {
                        IdRemito,
                        Fecha,
                        Tipo,
                        Numero,
                        IdCuenta,
                        IdEstado,
                        ConservaPreico,
                        IdCondicionDeVenta,
                        Comentario,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtlg_RemitoRow);
                return rowtlg_RemitoRow;
            }
            
            public tlg_RemitoRow FindByIdRemito(long IdRemito) {
                return ((tlg_RemitoRow)(this.Rows.Find(new object[] {
                            IdRemito})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_RemitoDataTable cln = ((tlg_RemitoDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_RemitoDataTable();
            }
            
            internal void InitVars() {
                this.columnIdRemito = this.Columns["IdRemito"];
                this.columnFecha = this.Columns["Fecha"];
                this.columnTipo = this.Columns["Tipo"];
                this.columnNumero = this.Columns["Numero"];
                this.columnIdCuenta = this.Columns["IdCuenta"];
                this.columnIdEstado = this.Columns["IdEstado"];
                this.columnConservaPreico = this.Columns["ConservaPreico"];
                this.columnIdCondicionDeVenta = this.Columns["IdCondicionDeVenta"];
                this.columnComentario = this.Columns["Comentario"];
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
                this.columnIdRemito = new DataColumn("IdRemito", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRemito);
                this.columnFecha = new DataColumn("Fecha", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFecha);
                this.columnTipo = new DataColumn("Tipo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTipo);
                this.columnNumero = new DataColumn("Numero", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNumero);
                this.columnIdCuenta = new DataColumn("IdCuenta", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCuenta);
                this.columnIdEstado = new DataColumn("IdEstado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEstado);
                this.columnConservaPreico = new DataColumn("ConservaPreico", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnConservaPreico);
                this.columnIdCondicionDeVenta = new DataColumn("IdCondicionDeVenta", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCondicionDeVenta);
                this.columnComentario = new DataColumn("Comentario", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnComentario);
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
                this.Constraints.Add(new UniqueConstraint("tlg_RemitoKey1", new DataColumn[] {
                                this.columnIdRemito}, true));
                this.columnIdRemito.AllowDBNull = false;
                this.columnIdRemito.Unique = true;
                this.columnConservaPreico.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_RemitoRow Newtlg_RemitoRow() {
                return ((tlg_RemitoRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_RemitoRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_RemitoRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_RemitoRowChanged != null)) {
                    this.tlg_RemitoRowChanged(this, new tlg_RemitoRowChangeEvent(((tlg_RemitoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_RemitoRowChanging != null)) {
                    this.tlg_RemitoRowChanging(this, new tlg_RemitoRowChangeEvent(((tlg_RemitoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_RemitoRowDeleted != null)) {
                    this.tlg_RemitoRowDeleted(this, new tlg_RemitoRowChangeEvent(((tlg_RemitoRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_RemitoRowDeleting != null)) {
                    this.tlg_RemitoRowDeleting(this, new tlg_RemitoRowChangeEvent(((tlg_RemitoRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_RemitoRow(tlg_RemitoRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_RemitoRow : DataRow {
            
            private tlg_RemitoDataTable tabletlg_Remito;
            
            internal tlg_RemitoRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_Remito = ((tlg_RemitoDataTable)(this.Table));
            }
            
            public long IdRemito {
                get {
                    return ((long)(this[this.tabletlg_Remito.IdRemitoColumn]));
                }
                set {
                    this[this.tabletlg_Remito.IdRemitoColumn] = value;
                }
            }
            
            public System.DateTime Fecha {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_Remito.FechaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.FechaColumn] = value;
                }
            }
            
            public string Tipo {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Remito.TipoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.TipoColumn] = value;
                }
            }
            
            public string Numero {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Remito.NumeroColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.NumeroColumn] = value;
                }
            }
            
            public string IdCuenta {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Remito.IdCuentaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdCuentaColumn] = value;
                }
            }
            
            public long IdEstado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Remito.IdEstadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdEstadoColumn] = value;
                }
            }
            
            public bool ConservaPreico {
                get {
                    return ((bool)(this[this.tabletlg_Remito.ConservaPreicoColumn]));
                }
                set {
                    this[this.tabletlg_Remito.ConservaPreicoColumn] = value;
                }
            }
            
            public long IdCondicionDeVenta {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Remito.IdCondicionDeVentaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdCondicionDeVentaColumn] = value;
                }
            }
            
            public string Comentario {
                get {
                    try {
                        return ((string)(this[this.tabletlg_Remito.ComentarioColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.ComentarioColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_Remito.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Remito.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_Remito.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Remito.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Remito.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_Remito.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Remito.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletlg_Remito.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_Remito.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsFechaNull() {
                return this.IsNull(this.tabletlg_Remito.FechaColumn);
            }
            
            public void SetFechaNull() {
                this[this.tabletlg_Remito.FechaColumn] = System.Convert.DBNull;
            }
            
            public bool IsTipoNull() {
                return this.IsNull(this.tabletlg_Remito.TipoColumn);
            }
            
            public void SetTipoNull() {
                this[this.tabletlg_Remito.TipoColumn] = System.Convert.DBNull;
            }
            
            public bool IsNumeroNull() {
                return this.IsNull(this.tabletlg_Remito.NumeroColumn);
            }
            
            public void SetNumeroNull() {
                this[this.tabletlg_Remito.NumeroColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdCuentaNull() {
                return this.IsNull(this.tabletlg_Remito.IdCuentaColumn);
            }
            
            public void SetIdCuentaNull() {
                this[this.tabletlg_Remito.IdCuentaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEstadoNull() {
                return this.IsNull(this.tabletlg_Remito.IdEstadoColumn);
            }
            
            public void SetIdEstadoNull() {
                this[this.tabletlg_Remito.IdEstadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdCondicionDeVentaNull() {
                return this.IsNull(this.tabletlg_Remito.IdCondicionDeVentaColumn);
            }
            
            public void SetIdCondicionDeVentaNull() {
                this[this.tabletlg_Remito.IdCondicionDeVentaColumn] = System.Convert.DBNull;
            }
            
            public bool IsComentarioNull() {
                return this.IsNull(this.tabletlg_Remito.ComentarioColumn);
            }
            
            public void SetComentarioNull() {
                this[this.tabletlg_Remito.ComentarioColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_Remito.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_Remito.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_Remito.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_Remito.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_Remito.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_Remito.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_Remito.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_Remito.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_Remito.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_Remito.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_Remito.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_Remito.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletlg_Remito.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletlg_Remito.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletlg_Remito.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletlg_Remito.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_RemitoRowChangeEvent : EventArgs {
            
            private tlg_RemitoRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_RemitoRowChangeEvent(tlg_RemitoRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_RemitoRow Row {
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