using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a rectangular array of block references
///</summary>
namespace OdaX.AcadMInsertBlock 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMInsertBlock_Constructor : INode 
	{
		public OdaX.IAcadMInsertBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMInsertBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMInsertBlock_ConstructorCast : INode 
	{
		public OdaX.IAcadMInsertBlock _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMInsertBlock;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of vertical columns in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("NumColumns", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of vertical columns in the block pattern.
	///</summary>
	public class Set_Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Columns = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of vertical columns in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the number of vertical columns in the block pattern.
	///</summary>
	public class Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Columns);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the spacing between columns in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("Spacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the spacing between columns in the block pattern.
	///</summary>
	public class Set_ColumnSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColumnSpacing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the spacing between columns in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the spacing between columns in the block pattern.
	///</summary>
	public class ColumnSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnSpacing);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of horizontal rows in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("NumRows", typeof(System.Object))]

	///<summary>
	///Specifies or returns the number of horizontal rows in the block pattern.
	///</summary>
	public class Set_Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the number of horizontal rows in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the number of horizontal rows in the block pattern.
	///</summary>
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows);

		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the spacing between rows in the block pattern.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("Spacing", typeof(System.Double))]

	///<summary>
	///Specifies or returns the spacing between rows in the block pattern.
	///</summary>
	public class Set_RowSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowSpacing = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies or returns the spacing between rows in the block pattern.", 
		ViewType = "Data")]
	[NodeInput("AcadMInsertBlock", typeof(object))]

	///<summary>
	///Specifies or returns the spacing between rows in the block pattern.
	///</summary>
	public class RowSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowSpacing);

		}
	}
}
