using NVP.API.Nodes;

namespace OdaX.AcadMLeaderLeader 
{
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


	///<summary>
	///Specifies the leader type
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	public class LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderType);

		}
	}


	///<summary>
	///Specifies the leader type
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_LeaderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the color of the leader lines
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	public class LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineColor);

		}
	}


	///<summary>
	///Specifies the color of the leader lines
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]
	public class Set_LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the linetype of leader lines
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	public class LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineType);

		}
	}


	///<summary>
	///Specifies the linetype of leader lines
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Linetype", typeof(System.Object))]
	public class Set_LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the line weight of leader lines
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	public class LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineWeight);

		}
	}


	///<summary>
	///Specifies the line weight of leader lines
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("Lineweight", typeof(System.Object))]
	public class Set_LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineWeight = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the type of leader arrowhead
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	public class ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadType);

		}
	}


	///<summary>
	///Specifies the type of leader arrowhead
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.Object))]
	public class Set_ArrowheadType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadType = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the size of leader arrowhead
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	public class ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadSize);

		}
	}


	///<summary>
	///Specifies the size of leader arrowhead
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("size", typeof(System.Double))]
	public class Set_ArrowheadSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies the block to use as the custom arrowhead for leader lines of multileader
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	public class ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowheadBlock);

		}
	}


	///<summary>
	///Specifies the block to use as the custom arrowhead for leader lines of multileader
	///</summary>
	[NodeInput("AcadMLeaderLeader", typeof(object))]
	[NodeInput("BlockName", typeof(System.String))]
	public class Set_ArrowheadBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowheadBlock = inputs[1];
			return null;
		}
	}
}
