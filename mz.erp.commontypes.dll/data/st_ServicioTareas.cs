﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2443
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
    public class st_ServicioTareasDataset : DataSet {
        
        private st_ServicioTareasDataTable tablest_ServicioTareas;
        
        public st_ServicioTareasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected st_ServicioTareasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["st_ServicioTareas"] != null)) {
                    this.Tables.Add(new st_ServicioTareasDataTable(ds.Tables["st_ServicioTareas"]));
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
        public st_ServicioTareasDataTable st_ServicioTareas {
            get {
                return this.tablest_ServicioTareas;
            }
        }
        
        public override DataSet Clone() {
            st_ServicioTareasDataset cln = ((st_ServicioTareasDataset)(base.Clone()));
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
            if ((ds.Tables["st_ServicioTareas"] != null)) {
                this.Tables.Add(new st_ServicioTareasDataTable(ds.Tables["st_ServicioTareas"]));
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
            this.tablest_ServicioTareas = ((st_ServicioTareasDataTable)(this.Tables["st_ServicioTareas"]));
            if ((this.tablest_ServicioTareas != null)) {
                this.tablest_ServicioTareas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "st_ServicioTareasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/st_ServicioTareas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablest_ServicioTareas = new st_ServicioTareasDataTable();
            this.Tables.Add(this.tablest_ServicioTareas);
        }
        
        private bool ShouldSerializest_ServicioTareas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void st_ServicioTareasRowChangeEventHandler(object sender, st_ServicioTareasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_ServicioTareasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdServicio;
            
            private DataColumn columnIdTarea;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnPrecioTarea;
            
            private DataColumn columnPeso;
            
            internal st_ServicioTareasDataTable() : 
                    base("st_ServicioTareas") {
                this.InitClass();
            }
            
            internal st_ServicioTareasDataTable(DataTable table) : 
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
            
            internal DataColumn IdServicioColumn {
                get {
                    return this.columnIdServicio;
                }
            }
            
            internal DataColumn IdTareaColumn {
                get {
                    return this.columnIdTarea;
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
            
            internal DataColumn PrecioTareaColumn {
                get {
                    return this.columnPrecioTarea;
                }
            }
            
            internal DataColumn PesoColumn {
                get {
                    return this.columnPeso;
                }
            }
            
            public st_ServicioTareasRow this[int index] {
                get {
                    return ((st_ServicioTareasRow)(this.Rows[index]));
                }
            }
            
            public event st_ServicioTareasRowChangeEventHandler st_ServicioTareasRowChanged;
            
            public event st_ServicioTareasRowChangeEventHandler st_ServicioTareasRowChanging;
            
            public event st_ServicioTareasRowChangeEventHandler st_ServicioTareasRowDeleted;
            
            public event st_ServicioTareasRowChangeEventHandler st_ServicioTareasRowDeleting;
            
            public void Addst_ServicioTareasRow(st_ServicioTareasRow row) {
                this.Rows.Add(row);
            }
            
            public st_ServicioTareasRow Addst_ServicioTareasRow(long IdServicio, long IdTarea, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, System.Decimal PrecioTarea, System.Decimal Peso) {
                st_ServicioTareasRow rowst_ServicioTareasRow = ((st_ServicioTareasRow)(this.NewRow()));
                rowst_ServicioTareasRow.ItemArray = new object[] {
                        IdServicio,
                        IdTarea,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        PrecioTarea,
                        Peso};
                this.Rows.Add(rowst_ServicioTareasRow);
                return rowst_ServicioTareasRow;
            }
            
            public st_ServicioTareasRow FindByIdServicioIdTarea(long IdServicio, long IdTarea) {
                return ((st_ServicioTareasRow)(this.Rows.Find(new object[] {
                            IdServicio,
                            IdTarea})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                st_ServicioTareasDataTable cln = ((st_ServicioTareasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new st_ServicioTareasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdServicio = this.Columns["IdServicio"];
                this.columnIdTarea = this.Columns["IdTarea"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnPrecioTarea = this.Columns["PrecioTarea"];
                this.columnPeso = this.Columns["Peso"];
            }
            
            private void InitClass() {
                this.columnIdServicio = new DataColumn("IdServicio", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdServicio);
                this.columnIdTarea = new DataColumn("IdTarea", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTarea);
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
                this.columnPrecioTarea = new DataColumn("PrecioTarea", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPrecioTarea);
                this.columnPeso = new DataColumn("Peso", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPeso);
                this.Constraints.Add(new UniqueConstraint("st_ServicioTareasDatasetKey1", new DataColumn[] {
                                this.columnIdServicio,
                                this.columnIdTarea}, true));
                this.columnIdServicio.AllowDBNull = false;
                this.columnIdTarea.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public st_ServicioTareasRow Newst_ServicioTareasRow() {
                return ((st_ServicioTareasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new st_ServicioTareasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(st_ServicioTareasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.st_ServicioTareasRowChanged != null)) {
                    this.st_ServicioTareasRowChanged(this, new st_ServicioTareasRowChangeEvent(((st_ServicioTareasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.st_ServicioTareasRowChanging != null)) {
                    this.st_ServicioTareasRowChanging(this, new st_ServicioTareasRowChangeEvent(((st_ServicioTareasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.st_ServicioTareasRowDeleted != null)) {
                    this.st_ServicioTareasRowDeleted(this, new st_ServicioTareasRowChangeEvent(((st_ServicioTareasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.st_ServicioTareasRowDeleting != null)) {
                    this.st_ServicioTareasRowDeleting(this, new st_ServicioTareasRowChangeEvent(((st_ServicioTareasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removest_ServicioTareasRow(st_ServicioTareasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_ServicioTareasRow : DataRow {
            
            private st_ServicioTareasDataTable tablest_ServicioTareas;
            
            internal st_ServicioTareasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablest_ServicioTareas = ((st_ServicioTareasDataTable)(this.Table));
            }
            
            public long IdServicio {
                get {
                    return ((long)(this[this.tablest_ServicioTareas.IdServicioColumn]));
                }
                set {
                    this[this.tablest_ServicioTareas.IdServicioColumn] = value;
                }
            }
            
            public long IdTarea {
                get {
                    return ((long)(this[this.tablest_ServicioTareas.IdTareaColumn]));
                }
                set {
                    this[this.tablest_ServicioTareas.IdTareaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablest_ServicioTareas.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_ServicioTareas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablest_ServicioTareas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablest_ServicioTareas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablest_ServicioTareas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_ServicioTareas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablest_ServicioTareas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_ServicioTareas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablest_ServicioTareas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_ServicioTareas.RowIdColumn] = value;
                }
            }
            
            public System.Decimal PrecioTarea {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablest_ServicioTareas.PrecioTareaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_ServicioTareas.PrecioTareaColumn] = value;
                }
            }
            
            public System.Decimal Peso {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablest_ServicioTareas.PesoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_ServicioTareas.PesoColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablest_ServicioTareas.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablest_ServicioTareas.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablest_ServicioTareas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablest_ServicioTareas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablest_ServicioTareas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablest_ServicioTareas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablest_ServicioTareas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablest_ServicioTareas.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsPrecioTareaNull() {
                return this.IsNull(this.tablest_ServicioTareas.PrecioTareaColumn);
            }
            
            public void SetPrecioTareaNull() {
                this[this.tablest_ServicioTareas.PrecioTareaColumn] = System.Convert.DBNull;
            }
            
            public bool IsPesoNull() {
                return this.IsNull(this.tablest_ServicioTareas.PesoColumn);
            }
            
            public void SetPesoNull() {
                this[this.tablest_ServicioTareas.PesoColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_ServicioTareasRowChangeEvent : EventArgs {
            
            private st_ServicioTareasRow eventRow;
            
            private DataRowAction eventAction;
            
            public st_ServicioTareasRowChangeEvent(st_ServicioTareasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public st_ServicioTareasRow Row {
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
