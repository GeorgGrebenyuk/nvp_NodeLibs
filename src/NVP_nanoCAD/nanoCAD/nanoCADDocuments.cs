using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The collection of all drawings open in the current session
///</summary>
namespace nanoCAD.nanoCADDocuments 
{

	[NVP_Manifest(
		Id = "A225F19E-685F-4281-B10D-C987097B511D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.nanoCADDocuments_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "_nanoCADDocuments_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADDocuments_Constructor : INode 
	{
		public nanoCAD.InanoCADDocuments _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADDocuments;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "F211A4E4-4CA7-48FD-99FE-8FCE2E2A0CFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.nanoCADDocuments_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "_nanoCADDocuments_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADDocuments_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADDocuments _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADDocuments;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4CFE5459-EC57-4DF5-903D-F3F306520F2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocuments", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
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
		Id = "9C134646-60C3-428A-8991-47CDC51E114E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocuments", typeof(object))]

	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
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
		Id = "80764826-7375-4D58-9C35-DF1CCA0EE4FA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocuments", typeof(object))]

	///<summary>
	///Gets the Application object
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
		Id = "35FF5F3D-0A82-4354-A593-697E9E4EF5CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a member object and adds it to the appropriate collection", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocuments", typeof(object))]
	[NodeInput("TemplateName", typeof(System.Object))]

	///<summary>
	///Creates a member object and adds it to the appropriate collection
	///</summary>
	public class Add : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Add(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "13B1A678-99E3-422D-95BD-DF1ACAB609ED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.Open", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "Open", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "DWG) and makes it the active document", 
		ViewType = "Data")]
	[NodeInput("nanoCADDocuments", typeof(object))]
	[NodeInput("Name", typeof(System.String))]
	[NodeInput("ReadOnly", typeof(System.Object))]
	[NodeInput("Password", typeof(System.Object))]

	///<summary>
	///DWG) and makes it the active document
	///</summary>
	public class Open : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Open(inputs[1].Value,inputs[2].Value,inputs[3].Value));

		}
	}


	[NVP_Manifest(
		Id = "18A1BB39-9182-4486-959C-9F3CBD04BE62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADDocuments.Close", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADDocuments", 
		NodeName = "Close", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Closes all open documents and empties the documents collection.", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADDocuments", typeof(object))]

	///<summary>
	///Closes all open documents and empties the documents collection.
	///</summary>
	public class Close : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Close();
			return null;
		}
	}
}
