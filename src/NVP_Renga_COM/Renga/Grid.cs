using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace Renga.Grid 
{

	[NVP_Manifest(
		Id = "524C6197-83D5-40C8-B343-299CB2B57760", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.Grid_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "_Grid_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Grid_Constructor : INode 
	{
		public Renga.IGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "BBE20413-2B46-41B4-BF98-B6142F8B04BA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.Grid_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "_Grid_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class Grid_ConstructorCast : INode 
	{
		public Renga.IGrid _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IGrid;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C5FA8A4F-59E2-482F-B538-34511B53C83E", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.TriangleCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "TriangleCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TriangleCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TriangleCount);

		}
	}


	[NVP_Manifest(
		Id = "3D708B67-0183-4336-9678-0AB59C359D94", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetTriangle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetTriangle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTriangle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTriangle(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "D6DA0949-F4E1-42F7-959A-8E2DBAF95954", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.VertexCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "VertexCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class VertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.VertexCount);

		}
	}


	[NVP_Manifest(
		Id = "71DA94AC-00A4-4DA6-84B1-CA543DFB27D5", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetVertex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetVertex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetVertex(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "E163BCC1-F3C4-471C-9836-D63C516A6FF6", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.NormalCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "NormalCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class NormalCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NormalCount);

		}
	}


	[NVP_Manifest(
		Id = "EB1970DF-158E-4DAE-977C-77B20814E703", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetNormal", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetNormal", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetNormal : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetNormal(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8A0A0701-DE25-4385-9B36-63044D98C47B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.TextureCoordinateCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "TextureCoordinateCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class TextureCoordinateCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextureCoordinateCount);

		}
	}


	[NVP_Manifest(
		Id = "4878D336-B2E2-491E-8BFD-72BE1C7A215B", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetTextureCoordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetTextureCoordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class GetTextureCoordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetTextureCoordinate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "4E86285A-8B63-4610-BB80-03FE446B17AA", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GridType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GridType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GridType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridType);

		}
	}


	[NVP_Manifest(
		Id = "30D7DBB6-A88E-4997-A589-9AD6D6293315", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.DoubleSided", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "DoubleSided", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("Grid", typeof(object))]

	///<summary>
	///
	///</summary>
	public class DoubleSided : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoubleSided);

		}
	}


	[NVP_Manifest(
		Id = "23890F38-E950-4624-95F3-22E387B07B01", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetTriangleComponents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetTriangleComponents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("int*", typeof(System.Object))]
	[NodeInput("int*", typeof(System.Object))]
	[NodeInput("int*", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetTriangleComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetTriangleComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "33DD0D7C-DB97-4DF1-BA84-D1D9A7CBD5ED", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetVertexComponents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetVertexComponents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("pX", typeof(System.Object))]
	[NodeInput("pY", typeof(System.Object))]
	[NodeInput("pZ", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetVertexComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetVertexComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1E8DDB2A-2CB9-4C6C-BD7C-BF486F4BFB52", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetNormalComponents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetNormalComponents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("pX", typeof(System.Object))]
	[NodeInput("pY", typeof(System.Object))]
	[NodeInput("pZ", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetNormalComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetNormalComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A32FA38F-DDBE-478D-9C8C-5BE105E209B4", 
		PathAssembly = "NVP_Renga_COM.dll", 
		PathExecuteClass = "Renga.Grid.GetTextureCoordinateComponents", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_Renga_COM.Renga.Grid", 
		NodeName = "GetTextureCoordinateComponents", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("Grid", typeof(object))]
	[NodeInput("index", typeof(System.Int32))]
	[NodeInput("pX", typeof(System.Object))]
	[NodeInput("pY", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class GetTextureCoordinateComponents : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetTextureCoordinateComponents(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}
}
