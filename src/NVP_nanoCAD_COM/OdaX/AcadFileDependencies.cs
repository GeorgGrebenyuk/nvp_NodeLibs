using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for creating, updating, retrieving and removing items in the File Dependency List
///</summary>
namespace OdaX.AcadFileDependencies 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadFileDependencies_Constructor : INode 
	{
		public OdaX.IAcadFileDependencies _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadFileDependencies;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadFileDependencies_ConstructorCast : INode 
	{
		public OdaX.IAcadFileDependencies _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadFileDependencies;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns an object at a given index in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]
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
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]

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
		Text = "Returns the number of items in the collection.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]

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
		Text = "Creates an entry in the File Dependencis list.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Feature", typeof(System.String))]
	[NodeInput("FullFileName", typeof(System.String))]
	[NodeInput("AffectsGraphics", typeof(System.Object))]
	[NodeInput("noIncrement", typeof(System.Object))]

	///<summary>
	///Creates an entry in the File Dependencis list.
	///</summary>
	public class CreateEntry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CreateEntry(inputs[1].Value,inputs[2].Value,inputs[3].Value,inputs[4].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the index in the collection of a specified entry.", 
		ViewType = "Data")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Feature", typeof(System.String))]
	[NodeInput("FullFileName", typeof(System.String))]

	///<summary>
	///Returns the index in the collection of a specified entry.
	///</summary>
	public class IndexOf : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IndexOf(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Removes an entry from the File Dependencies list.", 
		ViewType = "Modifier")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	[NodeInput("forceRemove", typeof(System.Object))]

	///<summary>
	///Removes an entry from the File Dependencies list.
	///</summary>
	public class RemoveEntry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveEntry(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Updates an entry in the File Dependencies list.", 
		ViewType = "Modifier")]
	[NodeInput("AcadFileDependencies", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Updates an entry in the File Dependencies list.
	///</summary>
	public class UpdateEntry : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UpdateEntry(inputs[1].Value);
			return null;
		}
	}
}
