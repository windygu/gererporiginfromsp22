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
    public class PerfilesElementosNavegacionDataset : DataSet {
        
        private PerfilesElementosNavegacionDataTable tablePerfilesElementosNavegacion;
        
        public PerfilesElementosNavegacionDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected PerfilesElementosNavegacionDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["PerfilesElementosNavegacion"] != null)) {
                    this.Tables.Add(new PerfilesElementosNavegacionDataTable(ds.Tables["PerfilesElementosNavegacion"]));
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
        public PerfilesElementosNavegacionDataTable PerfilesElementosNavegacion {
            get {
                return this.tablePerfilesElementosNavegacion;
            }
        }
        
        public override DataSet Clone() {
            PerfilesElementosNavegacionDataset cln = ((PerfilesElementosNavegacionDataset)(base.Clone()));
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
            if ((ds.Tables["PerfilesElementosNavegacion"] != null)) {
                this.Tables.Add(new PerfilesElementosNavegacionDataTable(ds.Tables["PerfilesElementosNavegacion"]));
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
            this.tablePerfilesElementosNavegacion = ((PerfilesElementosNavegacionDataTable)(this.Tables["PerfilesElementosNavegacion"]));
            if ((this.tablePerfilesElementosNavegacion != null)) {
                this.tablePerfilesElementosNavegacion.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "PerfilesElementosNavegacionDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/PerfilesElementosNavegacionDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablePerfilesElementosNavegacion = new PerfilesElementosNavegacionDataTable();
            this.Tables.Add(this.tablePerfilesElementosNavegacion);
        }
        
        private bool ShouldSerializePerfilesElementosNavegacion() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void PerfilesElementosNavegacionRowChangeEventHandler(object sender, PerfilesElementosNavegacionRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesElementosNavegacionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnidPerfil;
            
            private DataColumn columnidElementoNavegacion;
            
            internal PerfilesElementosNavegacionDataTable() : 
                    base("PerfilesElementosNavegacion") {
                this.InitClass();
            }
            
            internal PerfilesElementosNavegacionDataTable(DataTable table) : 
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
            
            internal DataColumn idPerfilColumn {
                get {
                    return this.columnidPerfil;
                }
            }
            
            internal DataColumn idElementoNavegacionColumn {
                get {
                    return this.columnidElementoNavegacion;
                }
            }
            
            public PerfilesElementosNavegacionRow this[int index] {
                get {
                    return ((PerfilesElementosNavegacionRow)(this.Rows[index]));
                }
            }
            
            public event PerfilesElementosNavegacionRowChangeEventHandler PerfilesElementosNavegacionRowChanged;
            
            public event PerfilesElementosNavegacionRowChangeEventHandler PerfilesElementosNavegacionRowChanging;
            
            public event PerfilesElementosNavegacionRowChangeEventHandler PerfilesElementosNavegacionRowDeleted;
            
            public event PerfilesElementosNavegacionRowChangeEventHandler PerfilesElementosNavegacionRowDeleting;
            
            public void AddPerfilesElementosNavegacionRow(PerfilesElementosNavegacionRow row) {
                this.Rows.Add(row);
            }
            
            public PerfilesElementosNavegacionRow AddPerfilesElementosNavegacionRow(long idPerfil, long idElementoNavegacion) {
                PerfilesElementosNavegacionRow rowPerfilesElementosNavegacionRow = ((PerfilesElementosNavegacionRow)(this.NewRow()));
                rowPerfilesElementosNavegacionRow.ItemArray = new object[] {
                        idPerfil,
                        idElementoNavegacion};
                this.Rows.Add(rowPerfilesElementosNavegacionRow);
                return rowPerfilesElementosNavegacionRow;
            }
            
            public PerfilesElementosNavegacionRow FindByidPerfilidElementoNavegacion(long idPerfil, long idElementoNavegacion) {
                return ((PerfilesElementosNavegacionRow)(this.Rows.Find(new object[] {
                            idPerfil,
                            idElementoNavegacion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                PerfilesElementosNavegacionDataTable cln = ((PerfilesElementosNavegacionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new PerfilesElementosNavegacionDataTable();
            }
            
            internal void InitVars() {
                this.columnidPerfil = this.Columns["idPerfil"];
                this.columnidElementoNavegacion = this.Columns["idElementoNavegacion"];
            }
            
            private void InitClass() {
                this.columnidPerfil = new DataColumn("idPerfil", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnidPerfil);
                this.columnidElementoNavegacion = new DataColumn("idElementoNavegacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnidElementoNavegacion);
                this.Constraints.Add(new UniqueConstraint("PerfilesElementosNavegacionDatasetKey1", new DataColumn[] {
                                this.columnidPerfil,
                                this.columnidElementoNavegacion}, true));
                this.columnidPerfil.AllowDBNull = false;
                this.columnidElementoNavegacion.AllowDBNull = false;
            }
            
            public PerfilesElementosNavegacionRow NewPerfilesElementosNavegacionRow() {
                return ((PerfilesElementosNavegacionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new PerfilesElementosNavegacionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(PerfilesElementosNavegacionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.PerfilesElementosNavegacionRowChanged != null)) {
                    this.PerfilesElementosNavegacionRowChanged(this, new PerfilesElementosNavegacionRowChangeEvent(((PerfilesElementosNavegacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.PerfilesElementosNavegacionRowChanging != null)) {
                    this.PerfilesElementosNavegacionRowChanging(this, new PerfilesElementosNavegacionRowChangeEvent(((PerfilesElementosNavegacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.PerfilesElementosNavegacionRowDeleted != null)) {
                    this.PerfilesElementosNavegacionRowDeleted(this, new PerfilesElementosNavegacionRowChangeEvent(((PerfilesElementosNavegacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.PerfilesElementosNavegacionRowDeleting != null)) {
                    this.PerfilesElementosNavegacionRowDeleting(this, new PerfilesElementosNavegacionRowChangeEvent(((PerfilesElementosNavegacionRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovePerfilesElementosNavegacionRow(PerfilesElementosNavegacionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesElementosNavegacionRow : DataRow {
            
            private PerfilesElementosNavegacionDataTable tablePerfilesElementosNavegacion;
            
            internal PerfilesElementosNavegacionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablePerfilesElementosNavegacion = ((PerfilesElementosNavegacionDataTable)(this.Table));
            }
            
            public long idPerfil {
                get {
                    return ((long)(this[this.tablePerfilesElementosNavegacion.idPerfilColumn]));
                }
                set {
                    this[this.tablePerfilesElementosNavegacion.idPerfilColumn] = value;
                }
            }
            
            public long idElementoNavegacion {
                get {
                    return ((long)(this[this.tablePerfilesElementosNavegacion.idElementoNavegacionColumn]));
                }
                set {
                    this[this.tablePerfilesElementosNavegacion.idElementoNavegacionColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class PerfilesElementosNavegacionRowChangeEvent : EventArgs {
            
            private PerfilesElementosNavegacionRow eventRow;
            
            private DataRowAction eventAction;
            
            public PerfilesElementosNavegacionRowChangeEvent(PerfilesElementosNavegacionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public PerfilesElementosNavegacionRow Row {
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
