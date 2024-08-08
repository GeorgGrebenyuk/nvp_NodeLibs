using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///The standard interface for a basic TeighaX object
///</summary>
namespace OdaX.AcadObject 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadObject_Constructor : INode 
	{
		public OdaX.IAcadObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadObject_ConstructorCast : INode 
	{
		public OdaX.IAcadObject _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadObject;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns the handle of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the handle of an object.
	///</summary>
	public class Handle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Handle);

		}
	}


	[NVP_Manifest(
		Text = "Returns the TeighaX class name of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the TeighaX class name of an object.
	///</summary>
	public class ObjectName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectName);

		}
	}


	[NVP_Manifest(
		Text = "XData) associated with an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]
	[NodeInput("AppName", typeof(System.String))]
	[NodeInput("XDataType", typeof(System.Object))]
	[NodeInput("XDataValue", typeof(System.Object))]

	///<summary>
	///XData) associated with an object.
	///</summary>
	public class GetXData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetXData(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "XData) associated with an object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]
	[NodeInput("XDataType", typeof(System.Object))]
	[NodeInput("XDataValue", typeof(System.Object))]

	///<summary>
	///XData) associated with an object.
	///</summary>
	public class SetXData : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetXData(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Deletes a specified object.", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Deletes a specified object.
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the object ID of an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the object ID of an object.
	///</summary>
	public class ObjectID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ObjectID);

		}
	}


	[NVP_Manifest(
		Text = "Returns the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

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
		Text = "Returns the database in which the object belongs.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the database in which the object belongs.
	///</summary>
	public class Database : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Database);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether an object has an associated extension dictionary.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns whether an object has an associated extension dictionary.
	///</summary>
	public class HasExtensionDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasExtensionDictionary);

		}
	}


	[NVP_Manifest(
		Text = "Returns the extension dictionary associated with an object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the extension dictionary associated with an object.
	///</summary>
	public class GetExtensionDictionary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetExtensionDictionary);

		}
	}


	[NVP_Manifest(
		Text = "Returns the object ID of the parent object.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the object ID of the parent object.
	///</summary>
	public class OwnerID : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OwnerID);

		}
	}


	[NVP_Manifest(
		Text = "Returns the drawing to which an object belongs.", 
		ViewType = "Data")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Returns the drawing to which an object belongs.
	///</summary>
	public class Document : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Document);

		}
	}


	[NVP_Manifest(
		Text = "Erases all the objects in a selection set", 
		ViewType = "Modifier")]
	[NodeInput("AcadObject", typeof(object))]

	///<summary>
	///Erases all the objects in a selection set
	///</summary>
	public class HiddenField_Erase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return null;
		}
	}
}
