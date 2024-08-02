using NVP.API.Nodes;

namespace Renga.TitleBlockInstance 
{
	[NodeInput("dynamic", typeof(object))]
	public class TitleBlockInstance_Constructor : INode 
	{
		public Renga.ITitleBlockInstance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.ITitleBlockInstance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class TitleBlockInstance_ConstructorCast : INode 
	{
		public Renga.ITitleBlockInstance _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.ITitleBlockInstance;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("TitleBlockInstance", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("TitleBlockInstance", typeof(object))]
	public class RowCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RowCount);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("TitleBlockInstance", typeof(object))]
	public class ColumnCount : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ColumnCount);

		}
	}


	///<summary>
	///
	///</summary>
	[NodeInput("TitleBlockInstance", typeof(object))]
	[NodeInput("columnIndex", typeof(System.Int32))]
	[NodeInput("rowIndex", typeof(System.Int32))]
	public class GetCellValue : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetCellValue(inputs[1],inputs[2]));

		}
	}
}
