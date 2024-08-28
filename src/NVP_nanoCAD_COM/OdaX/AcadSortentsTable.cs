using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface to contain and manipulate draw order information
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadSortentsTable 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSortentsTable_Constructor : INode 
	{
		public OdaX.IAcadSortentsTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadSortentsTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadSortentsTable_ConstructorCast : INode 
	{
		public OdaX.IAcadSortentsTable _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadSortentsTable;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Moves objects to the bottom of the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Moves objects to the bottom of the draw order.
	///</summary>
	public class MoveToBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveToBottom(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Moves objects to the top of the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Moves objects to the top of the draw order.
	///</summary>
	public class MoveToTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveToTop(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Moves objects below a specified object in the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Target", typeof(System.Object))]

	///<summary>
	///Moves objects below a specified object in the draw order.
	///</summary>
	public class MoveBelow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveBelow(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Moves objects above a specified object in the draw order.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Target", typeof(System.Object))]

	///<summary>
	///Moves objects above a specified object in the draw order.
	///</summary>
	public class MoveAbove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveAbove(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Exchanges draw order position for two specified objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Object1", typeof(System.Object))]
	[NodeInput("Object2", typeof(System.Object))]

	///<summary>
	///Exchanges draw order position for two specified objects.
	///</summary>
	public class SwapOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SwapOrder(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the block referenced by a sortents table.", 
		ViewType = "Data")]
	[NodeInput("AcadSortentsTable", typeof(object))]

	///<summary>
	///Returns the block referenced by a sortents table.
	///</summary>
	public class Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Block);

		}
	}


	[NVP_Manifest(
		Text = "Returns all objects in the referenced block, sorted by draw order with the bottom-most object first.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("honorSortentsSysvar", typeof(System.Object))]

	///<summary>
	///Returns all objects in the referenced block, sorted by draw order with the bottom-most object first.
	///</summary>
	public class GetFullDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFullDrawOrder(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Returns the specified objects, sorted by draw order with the bottom-most object first.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("honorSortentsSysvar", typeof(System.Object))]

	///<summary>
	///Returns the specified objects, sorted by draw order with the bottom-most object first.
	///</summary>
	public class GetRelativeDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRelativeDrawOrder(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the relative draw order for the specified objects.", 
		ViewType = "Modifier")]
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Specifies the relative draw order for the specified objects.
	///</summary>
	public class SetRelativeDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRelativeDrawOrder(inputs[1].Value);
			return null;
		}
	}
}
