using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a free-form 3D mesh entity
///</summary>
namespace OdaX.AcadPolygonMesh 
{

	[NVP_Manifest(
		Id = "BE271FC1-F549-46E9-9961-9B8592031635", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.AcadPolygonMesh_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "_AcadPolygonMesh_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolygonMesh_Constructor : INode 
	{
		public OdaX.IAcadPolygonMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPolygonMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8F450A2B-D2C0-409A-9667-9804E88DD953", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.AcadPolygonMesh_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "_AcadPolygonMesh_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolygonMesh_ConstructorCast : INode 
	{
		public OdaX.IAcadPolygonMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPolygonMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "3A4BFBA8-E3A5-45EE-A7C6-1ACE9623F72B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the coordinates of a polygon mesh.
	///</summary>
	public class Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinates);

		}
	}


	[NVP_Manifest(
		Id = "80900377-F61B-4CE2-8DAC-79FB17107129", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinates of a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("Coordinates", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinates of a polygon mesh.
	///</summary>
	public class Set_Coordinates : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinates = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42C775E0-061E-448D-8129-193A6FDF6C76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.MClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "MClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the mesh is open or closed in the M direction.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the M direction.
	///</summary>
	public class MClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MClose);

		}
	}


	[NVP_Manifest(
		Id = "00D38E07-E3B2-4DFC-BAF3-72BC988F3797", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Set_MClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Set_MClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the mesh is open or closed in the M direction.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("bClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the M direction.
	///</summary>
	public class Set_MClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MClose = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "02152561-9BDD-4F77-B49B-0A979A865423", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.NClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "NClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the mesh is open or closed in the N direction.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the N direction.
	///</summary>
	public class NClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NClose);

		}
	}


	[NVP_Manifest(
		Id = "0281D22E-8C48-4CE6-B4C0-FDD735476DB5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Set_NClose", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Set_NClose", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the mesh is open or closed in the N direction.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("bClose", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the mesh is open or closed in the N direction.
	///</summary>
	public class Set_NClose : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NClose = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F611D6A4-C91E-4A4F-B870-8D8F91672D07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.MDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "MDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the density of a polygon mesh in the M direction.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the M direction.
	///</summary>
	public class MDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MDensity);

		}
	}


	[NVP_Manifest(
		Id = "E47CA604-04D3-49D6-BFCF-F9B34FAA24DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Set_MDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Set_MDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the density of a polygon mesh in the M direction.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the M direction.
	///</summary>
	public class Set_MDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "22D799A4-5C2A-40B3-AD88-CAAEC5750107", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.NDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "NDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the density of a polygon mesh in the N direction", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the N direction
	///</summary>
	public class NDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NDensity);

		}
	}


	[NVP_Manifest(
		Id = "78F9C4C9-2240-480E-9D18-8358E43FA424", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Set_NDensity", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Set_NDensity", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the density of a polygon mesh in the N direction", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("density", typeof(System.Object))]

	///<summary>
	///Specifies or returns the density of a polygon mesh in the N direction
	///</summary>
	public class Set_NDensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.NDensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5BFA4738-AA61-4A13-90A4-96723AC4EA77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.MVertexCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "MVertexCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of verticies in the M direction of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Returns the number of verticies in the M direction of a polygon mesh.
	///</summary>
	public class MVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MVertexCount);

		}
	}


	[NVP_Manifest(
		Id = "061777C5-4AA9-4768-8A1B-15085789BD5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.NVertexCount", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "NVertexCount", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of verticies in the N direction of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Returns the number of verticies in the N direction of a polygon mesh.
	///</summary>
	public class NVertexCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NVertexCount);

		}
	}


	[NVP_Manifest(
		Id = "CA8D5B8D-F546-49E7-B697-96E589E40C70", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Specifies or returns the type of a polygon mesh.
	///</summary>
	public class Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Type);

		}
	}


	[NVP_Manifest(
		Id = "FDA1ECD9-923D-4852-A2FD-886F98C6AE5A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Set_Type", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Set_Type", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the type of a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("OdaX.AcPolymeshType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the type of a polygon mesh.
	///</summary>
	public class Set_Type : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Type = ((OdaX.AcPolymeshType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "4F7719BD-4EB1-4236-9DB0-7D5B1BCE8131", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.AppendVertex", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "AppendVertex", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Appends a new vertex to a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("vertex", typeof(System.Object))]

	///<summary>
	///Appends a new vertex to a polygon mesh.
	///</summary>
	public class AppendVertex : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendVertex(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "72C49886-972B-4CD1-A53B-2E18C6B9B188", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Explode", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Explode", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Explodes the polygon mesh and returns the individual entities as an array of the object.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]

	///<summary>
	///Explodes the polygon mesh and returns the individual entities as an array of the object.
	///</summary>
	public class Explode : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Explode);

		}
	}


	[NVP_Manifest(
		Id = "9578CE4A-608F-458F-9C07-D8B78E40E2B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in a polygon mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polygon mesh.
	///</summary>
	public class Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Coordinate(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "628BB725-298D-429D-9288-BDF1B5477F9C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolygonMesh.Set_Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolygonMesh", 
		NodeName = "Set_Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in a polygon mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolygonMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polygon mesh.
	///</summary>
	public class Set_Coordinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Coordinate[inputs[1]] = inputs[2];
			return null;
		}
	}
}
