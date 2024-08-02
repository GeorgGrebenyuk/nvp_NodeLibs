using NVP.API.Nodes;

namespace Renga.ColumnStyleManager 
{
		[NodeInput("dynamic", typeof(object))]
		public class ColumnStyleManager_Constructor : INode 
		{
		public Renga.IColumnStyleManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IColumnStyleManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ColumnStyleManager_ConstructorCast : INode 
		{
		public Renga.IColumnStyleManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IColumnStyleManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnStyleManager", typeof(object))]
		public class GetIds : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetIds();
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnStyleManager", typeof(object))]
		[NodeInput("Id", typeof(System.Int32))]
		public class Contains : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Contains(inputs[1]));

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnStyleManager", typeof(object))]
		[NodeInput("Id", typeof(System.Int32))]
		public class GetColumnStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetColumnStyle(inputs[1]));

			}
		}
}
