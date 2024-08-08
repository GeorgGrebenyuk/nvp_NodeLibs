using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a container object for storing and retrieving objects
///</summary>
namespace OdaX.AcadDictionary 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDictionary_Constructor : INode 
	{
		public OdaX.IAcadDictionary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadDictionary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadDictionary_ConstructorCast : INode 
	{
		public OdaX.IAcadDictionary _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadDictionary;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]

	///<summary>
	///Specifies or returns the name of a dictionary.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the name of a dictionary.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a dictionary.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Adds an object to a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Keyword", typeof(System.String))]
	[NodeInput("ObjectName", typeof(System.String))]

	///<summary>
	///Adds an object to a dictionary.
	///</summary>
	public class AddObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddObject(inputs[1].Value,inputs[2].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns the keyword string of an object in a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Object", typeof(System.Object))]

	///<summary>
	///Returns the keyword string of an object in a dictionary.
	///</summary>
	public class GetName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetName(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Returns an object in a dictionary using the keyword string associated with the object.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Returns an object in a dictionary using the keyword string associated with the object.
	///</summary>
	public class GetObject : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetObject(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Deletes an object from a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Deletes an object from a dictionary.
	///</summary>
	public class Remove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Remove(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Text = "Renames an object in a dictionary.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("OldName", typeof(System.String))]
	[NodeInput("NewName", typeof(System.String))]

	///<summary>
	///Renames an object in a dictionary.
	///</summary>
	public class Rename : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rename(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Replaces an object in a dictionary with another object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("OldName", typeof(System.String))]
	[NodeInput("pObj", typeof(System.Object))]

	///<summary>
	///Replaces an object in a dictionary with another object.
	///</summary>
	public class Replace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Replace(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns an object in a dictionary using the index associated with the object.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object in a dictionary using the index associated with the object.
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
		Text = "Returns the number of objects in a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]

	///<summary>
	///Returns the number of objects in a dictionary.
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
		Text = "Adds an XRecord object to a dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadDictionary", typeof(object))]
	[NodeInput("Keyword", typeof(System.String))]

	///<summary>
	///Adds an XRecord object to a dictionary.
	///</summary>
	public class AddXRecord : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AddXRecord(inputs[1].Value));

		}
	}
}
