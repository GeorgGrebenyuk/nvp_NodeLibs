using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///AutoCAD Interface for Multi-Leader's Leader Line
///</summary>
namespace OdaX.AcadMLeaderLeader 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderLeader_Constructor : INode 
	{
		public OdaX.IAcadMLeaderLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMLeaderLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderLeader_ConstructorCast : INode 
	{
		public OdaX.IAcadMLeaderLeader _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMLeaderLeader;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Text = "Specifies the leader type", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the leader type
	///</summary>
	public class LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the leader type", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("OdaX.AcMLeaderType", typeof(System.Object))]

	///<summary>
	///Specifies the leader type
	///</summary>
	public class Set_LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderType = ((OdaX.AcMLeaderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the color of the leader lines", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the color of the leader lines
	///</summary>
	public class LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineColor);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the color of the leader lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies the color of the leader lines
	///</summary>
	public class Set_LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the linetype of leader lines", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the linetype of leader lines
	///</summary>
	public class LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the linetype of leader lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Linetype", typeof(System.Object))]

	///<summary>
	///Specifies the linetype of leader lines
	///</summary>
	public class Set_LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the line weight of leader lines", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the line weight of leader lines
	///</summary>
	public class LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineWeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the line weight of leader lines", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]

	///<summary>
	///Specifies the line weight of leader lines
	///</summary>
	public class Set_LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineWeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the type of leader arrowhead", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the type of leader arrowhead
	///</summary>
	public class ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the type of leader arrowhead", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("OdaX.AcDimArrowheadType", typeof(System.Object))]

	///<summary>
	///Specifies the type of leader arrowhead
	///</summary>
	public class Set_ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadType = ((OdaX.AcDimArrowheadType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the size of leader arrowhead", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the size of leader arrowhead
	///</summary>
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the size of leader arrowhead", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies the size of leader arrowhead
	///</summary>
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the block to use as the custom arrowhead for leader lines of multileader", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]

	///<summary>
	///Specifies the block to use as the custom arrowhead for leader lines of multileader
	///</summary>
	public class ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadBlock);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the block to use as the custom arrowhead for leader lines of multileader", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]

	///<summary>
	///Specifies the block to use as the custom arrowhead for leader lines of multileader
	///</summary>
	public class Set_ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadBlock = inputs[1].Value;
			return null;
		}
	}
}
