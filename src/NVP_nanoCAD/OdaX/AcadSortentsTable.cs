using NVP.API.Nodes;

namespace OdaX.AcadSortentsTable 
{
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


	///<summary>
	///Moves objects to the bottom of the draw order.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	public class MoveToBottom : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveToBottom(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Moves objects to the top of the draw order.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	public class MoveToTop : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveToTop(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Moves objects below a specified object in the draw order.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Target", typeof(System.Object))]
	public class MoveBelow : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveBelow(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Moves objects above a specified object in the draw order.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("Target", typeof(System.Object))]
	public class MoveAbove : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MoveAbove(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Exchanges draw order position for two specified objects.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Object1", typeof(System.Object))]
	[NodeInput("Object2", typeof(System.Object))]
	public class SwapOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SwapOrder(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the block referenced by a sortents table.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	public class Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Block);

		}
	}


	///<summary>
	///Returns all objects in the referenced block, sorted by draw order with the bottom-most object first.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("honorSortentsSysvar", typeof(System.Object))]
	public class GetFullDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetFullDrawOrder(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Returns the specified objects, sorted by draw order with the bottom-most object first.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	[NodeInput("honorSortentsSysvar", typeof(System.Object))]
	public class GetRelativeDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetRelativeDrawOrder(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Specifies the relative draw order for the specified objects.
	///</summary>
	[NodeInput("AcadSortentsTable", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	public class SetRelativeDrawOrder : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetRelativeDrawOrder(inputs[1]);
			return null;
		}
	}
}
