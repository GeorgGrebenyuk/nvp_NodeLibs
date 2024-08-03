using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of the collection of all viewports in the drawing
///</summary>
namespace OdaX.AcadViewports 
{

	[NVP_Manifest(
		Id = "A7730A99-2FA9-44BD-B190-1FDFA67520B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewports.AcadViewports_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewports", 
		NodeName = "_AcadViewports_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewports_Constructor : INode 
	{
		public OdaX.IAcadViewports _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadViewports;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "6392D26E-10EC-47EB-AF6C-B94E00187A79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewports.AcadViewports_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewports", 
		NodeName = "_AcadViewports_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewports_ConstructorCast : INode 
	{
		public OdaX.IAcadViewports _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadViewports;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "369CFF09-6C73-4A24-BEC8-310D5B10B786", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewports.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewports", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("AcadViewports", typeof(object))]
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
		Id = "3B551F05-19AF-441E-8053-3A6CDCF5C981", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewports.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewports", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("AcadViewports", typeof(object))]

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
		Id = "A907AEAB-DF2D-411F-8694-3D0F3795CDAA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewports.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewports", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a member object and adds it to the appropriate collection", 
		ViewType = "Data")]
	[NodeInput("AcadViewports", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

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
		Id = "0D59F3DC-B11D-4030-9B33-164917493B3B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewports.DeleteConfiguration", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewports", 
		NodeName = "DeleteConfiguration", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a viewport configuration", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewports", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Deletes a viewport configuration
	///</summary>
	public class DeleteConfiguration : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DeleteConfiguration(inputs[1].Value);
			return null;
		}
	}
}
