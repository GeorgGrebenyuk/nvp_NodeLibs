using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for the collection of all mline styles in the drawing
///</summary>
namespace OdaX.OdaMLineStyles 
{

	[NVP_Manifest(
		Id = "62C4BE15-8742-40B6-AFA7-DE9E186093BC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyles.OdaMLineStyles_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyles", 
		NodeName = "_OdaMLineStyles_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyles_Constructor : INode 
	{
		public OdaX.IOdaMLineStyles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaMLineStyles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "5B092532-51FA-4711-A0BE-57A065491136", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyles.OdaMLineStyles_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyles", 
		NodeName = "_OdaMLineStyles_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaMLineStyles_ConstructorCast : INode 
	{
		public OdaX.IOdaMLineStyles _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaMLineStyles;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "AB2D714E-D6AD-47AB-95B6-AAAE0167A57D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyles.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyles", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyles", typeof(object))]
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
		Id = "5FBEF4B4-0458-4FAD-BF88-535D10735B4E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyles.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyles", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyles", typeof(object))]

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
		Id = "529A1711-DC33-4D6F-97A6-7EEB0C006277", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaMLineStyles.Add", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaMLineStyles", 
		NodeName = "Add", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Creates a member object and adds it to the appropriate collection", 
		ViewType = "Data")]
	[NodeInput("OdaMLineStyles", typeof(object))]
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
}
