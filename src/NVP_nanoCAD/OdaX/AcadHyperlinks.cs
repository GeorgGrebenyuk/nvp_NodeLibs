using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for the collection of all hyperlinks for a given entity
///</summary>
namespace OdaX.AcadHyperlinks 
{

	[NVP_Manifest(
		Id = "27B4F8F5-642C-44E1-956D-F0664452D79A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlinks.AcadHyperlinks_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlinks", 
		NodeName = "_AcadHyperlinks_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHyperlinks_Constructor : INode 
	{
		public OdaX.IAcadHyperlinks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadHyperlinks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "452BF790-366B-4956-A2F8-4B9728D103DE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlinks.AcadHyperlinks_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlinks", 
		NodeName = "_AcadHyperlinks_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadHyperlinks_ConstructorCast : INode 
	{
		public OdaX.IAcadHyperlinks _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadHyperlinks;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "C66B3050-04C0-479A-BB2C-1D866A9C4D80", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlinks.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlinks", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object at a given index in a collection.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlinks", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in a collection.
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
		Id = "FDDA6E2B-E622-4D72-B67D-3B3017E8B894", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlinks.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlinks", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of items in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlinks", typeof(object))]

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
		Id = "A698FD3E-B5F8-4DA7-BE0A-BC11B8B406BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlinks.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlinks", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlinks", typeof(object))]

	///<summary>
	///Returns the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "AD80EBB9-6260-4B9A-85EC-870405962942", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadHyperlinks.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadHyperlinks", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates an object and adds it to the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadHyperlinks", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("Description", typeof(System.Object))]
	[NodeInput("NamedLocation", typeof(System.Object))]

	///<summary>
	///Creates an object and adds it to the collection.
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}
}
