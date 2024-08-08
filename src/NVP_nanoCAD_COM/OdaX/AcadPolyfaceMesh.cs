using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a three-dimensional polyface mesh
///</summary>
namespace OdaX.AcadPolyfaceMesh 
{

	[NVP_Manifest(
		Id = "1AAC05C3-813B-44A5-818D-164923B396FC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.AcadPolyfaceMesh_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "_AcadPolyfaceMesh_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyfaceMesh_Constructor : INode 
	{
		public OdaX.IAcadPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "88671B0A-02EF-4F6B-A365-2B1650FC4166", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.AcadPolyfaceMesh_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "_AcadPolyfaceMesh_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadPolyfaceMesh_ConstructorCast : INode 
	{
		public OdaX.IAcadPolyfaceMesh _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadPolyfaceMesh;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "779E00FC-B34F-4AE2-B389-A21D1027A0DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.Set_Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "Set_Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertices of a polyface mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("Vertices", typeof(System.Object))]

	///<summary>
	///Specifies or returns the vertices of a polyface mesh.
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
		Id = "F8970380-E4E1-4467-8348-147AC3C08A76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.Coordinates", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "Coordinates", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the vertices of a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]

	///<summary>
	///Specifies or returns the vertices of a polyface mesh.
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
		Id = "CF72969C-E0B1-4F7D-A751-604DE2C8E10C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polyface mesh.
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
		Id = "74D3EC95-F3FF-4DE7-B57A-44EE2E618233", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.Set_Coordinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "Set_Coordinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the coordinate of a single vertex in a polyface mesh.", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("Index", typeof(System.Int32))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///Specifies or returns the coordinate of a single vertex in a polyface mesh.
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


	[NVP_Manifest(
		Id = "32DD081F-DFBC-4EA2-9753-BF08B4E634DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.NumberOfVertices", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "NumberOfVertices", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of vertices in a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]

	///<summary>
	///Returns the number of vertices in a polyface mesh.
	///</summary>
	public class NumberOfVertices : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfVertices);

		}
	}


	[NVP_Manifest(
		Id = "4353478C-1BD5-4832-B11F-2DA68C20A108", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.NumberOfFaces", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "NumberOfFaces", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the number of faces in a polyface mesh.", 
		ViewType = "Data")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]

	///<summary>
	///Specifies the number of faces in a polyface mesh.
	///</summary>
	public class NumberOfFaces : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.NumberOfFaces);

		}
	}


	[NVP_Manifest(
		Id = "594B7687-8232-45A9-A65A-A6FECE3C5C57", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadPolyfaceMesh.Set_Faces", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadPolyfaceMesh", 
		NodeName = "Set_Faces", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("AcadPolyfaceMesh", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Faces : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Faces = inputs[1].Value;
			return null;
		}
	}
}
