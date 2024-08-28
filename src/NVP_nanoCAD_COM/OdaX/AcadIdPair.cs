using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a special object for use with the CopyObjects method that contains the object IDs of both the source and destination objects
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadIdPair 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadIdPair_Constructor : INode 
	{
		public OdaX.IAcadIdPair _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadIdPair;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadIdPair_ConstructorCast : INode 
	{
		public OdaX.IAcadIdPair _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadIdPair;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Determines if the source object in a CopyObjects operation has been cloned", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Determines if the source object in a CopyObjects operation has been cloned
	///</summary>
	public class IsCloned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsCloned);

		}
	}


	[NVP_Manifest(
		Text = "Determines if the owning object in a CopyObjects operation has been translated", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Determines if the owning object in a CopyObjects operation has been translated
	///</summary>
	public class IsOwnerXlated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsOwnerXlated);

		}
	}


	[NVP_Manifest(
		Text = "Determines if the source object in a CopyObjects operation was part of the primary set of objects being copied, or if it was simply owned by a member in the primary set", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Determines if the source object in a CopyObjects operation was part of the primary set of objects being copied, or if it was simply owned by a member in the primary set
	///</summary>
	public class IsPrimary : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPrimary);

		}
	}


	[NVP_Manifest(
		Text = "The object ID of the source object in the CopyObjects operation", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///The object ID of the source object in the CopyObjects operation
	///</summary>
	public class key : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.key);

		}
	}


	[NVP_Manifest(
		Text = "The object ID of the newly created cloned object in the CopyObjects operation", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///The object ID of the newly created cloned object in the CopyObjects operation
	///</summary>
	public class Value : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Value);

		}
	}


	[NVP_Manifest(
		Text = "Gets the Application object.", 
		ViewType = "Data")]
	[NodeInput("AcadIdPair", typeof(object))]

	///<summary>
	///Gets the Application object.
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}
}
