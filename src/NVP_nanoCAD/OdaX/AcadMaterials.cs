using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for the collection of all materials in the drawing
///</summary>
namespace OdaX.AcadMaterials 
{

	[NVP_Manifest(
		Id = "063C892D-DBC9-44FE-A3FF-B1DB983D5F47", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterials.AcadMaterials_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterials", 
		NodeName = "_AcadMaterials_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMaterials_Constructor : INode 
	{
		public OdaX.IAcadMaterials _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMaterials;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2FC9851E-56B2-46C6-8FBF-066CA47A53B6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterials.AcadMaterials_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterials", 
		NodeName = "_AcadMaterials_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMaterials_ConstructorCast : INode 
	{
		public OdaX.IAcadMaterials _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMaterials;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "BA4599DF-7641-453F-8F77-CAC594F959A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterials.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterials", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object at a given index in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadMaterials", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the collection.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "3D626174-730F-4C55-B1F6-9D8D903B6458", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterials.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterials", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of items in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadMaterials", typeof(object))]

	///<summary>
	///Returns the number of items in the collection.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "DFD331D9-7E7F-431E-8E5F-AB400D79C71E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMaterials.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMaterials", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an object and adds it to the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadMaterials", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Creates an object and adds it to the collection.
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value));

		}
	}
}
