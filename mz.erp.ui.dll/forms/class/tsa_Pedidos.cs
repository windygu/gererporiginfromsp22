namespace mz.erp.ui
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsa_Pedidos : IDisposable, IGridDocument
	{
		public tsa_Pedidos()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdPedido""><Caption>IdPedido</Caption><DataMember>IdPedido</DataMember><Key>IdPedido</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Fecha""><Caption>Fecha</Caption><DataMember>Fecha</DataMember><Key>Fecha</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""FechaRegistracion""><Caption>FechaRegistracion</Caption><DataMember>FechaRegistracion</DataMember><Key>FechaRegistracion</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""IdResponsable""><Caption>IdResponsable</Caption><DataMember>IdResponsable</DataMember><Key>IdResponsable</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""IdCuenta""><Caption>IdCuenta</Caption><DataMember>IdCuenta</DataMember><Key>IdCuenta</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""Comentario""><Caption>Comentario</Caption><DataMember>Comentario</DataMember><Key>Comentario</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""FechaVencimiento""><Caption>FechaVencimiento</Caption><DataMember>FechaVencimiento</DataMember><Key>FechaVencimiento</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdEstado""><Caption>IdEstado</Caption><DataMember>IdEstado</DataMember><Key>IdEstado</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""Origen""><Caption>Origen</Caption><DataMember>Origen</DataMember><Key>Origen</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""FechaCierre""><Caption>FechaCierre</Caption><DataMember>FechaCierre</DataMember><Key>FechaCierre</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>14</Position></Column14>";
			returnValue += @"<Column15 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>15</Position></Column15>";
			returnValue += @"<Column16 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>16</Position></Column16>";
			returnValue += @"<Column17 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>17</Position></Column17>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_Pedidos.GetList().tsa_Pedidos;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_Pedidos.Update( ( tsa_PedidosDataset.tsa_PedidosDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

