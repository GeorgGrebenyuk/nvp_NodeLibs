using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface for an additional block functionality
///</summary>
namespace NVP_nanoCAD_COM._OdaX.OdaBlock 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaBlock_Constructor : INode 
	{
		public OdaX.IOdaBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaBlock_ConstructorCast : INode 
	{
		public OdaX.IOdaBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Returns all references for a block.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns all references for a block.
	///</summary>
	public class GetReferences : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetReferences);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether the block is an overlay.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is an overlay.
	///</summary>
	public class isFromOverlayReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isFromOverlayReference);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether the block is an external reference with a resolved path.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is an external reference with a resolved path.
	///</summary>
	public class isResolved : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isResolved);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether the block is dependent on an external reference.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is dependent on an external reference.
	///</summary>
	public class isDependent : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isDependent);

		}
	}


	[NVP_Manifest(
		Text = "Returns whether the block is an external reference that is unloaded.", 
		ViewType = "Data")]
	[NodeInput("OdaBlock", typeof(object))]

	///<summary>
	///Returns whether the block is an external reference that is unloaded.
	///</summary>
	public class isUnloaded : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.isUnloaded);

		}
	}


	[NVP_Manifest(
		Text = "Specfies whether a block is an overlay.", 
		ViewType = "Modifier")]
	[NodeInput("OdaBlock", typeof(object))]
	[NodeInput("bOverlaid", typeof(System.Object))]

	///<summary>
	///Specfies whether a block is an overlay.
	///</summary>
	public class setOverlaid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.setOverlaid(inputs[1].Value);
			return null;
		}
	}
}
