using NVP.API.Nodes;

namespace OdaX.AcadMInsertBlock 
{
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


	///<summary>
	///Specifies or returns the number of vertical columns in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("NumColumns", typeof(System.Object))]
	public class Set_Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Columns = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of vertical columns in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	public class Columns : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Columns);

		}
	}


	///<summary>
	///Specifies or returns the spacing between columns in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("Spacing", typeof(System.Double))]
	public class Set_ColumnSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ColumnSpacing = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the spacing between columns in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	public class ColumnSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnSpacing);

		}
	}


	///<summary>
	///Specifies or returns the number of horizontal rows in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("NumRows", typeof(System.Object))]
	public class Set_Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rows = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the number of horizontal rows in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	public class Rows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rows);

		}
	}


	///<summary>
	///Specifies or returns the spacing between rows in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	[NodeInput("Spacing", typeof(System.Double))]
	public class Set_RowSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RowSpacing = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the spacing between rows in the block pattern.
	///</summary>
	[NodeInput("AcadMInsertBlock", typeof(object))]
	public class RowSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowSpacing);

		}
	}
}
