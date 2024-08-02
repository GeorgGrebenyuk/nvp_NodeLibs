using NVP.API.Nodes;

namespace Renga.ColumnParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class ColumnParams_Constructor : INode 
		{
		public Renga.IColumnParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IColumnParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ColumnParams_ConstructorCast : INode 
		{
		public Renga.IColumnParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IColumnParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnParams", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnParams", typeof(object))]
		public class StyleId : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleId);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnParams", typeof(object))]
		public class GetProfilePlacement : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetProfilePlacement);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnParams", typeof(object))]
		public class Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Position);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ColumnParams", typeof(object))]
		public class VerticalOffset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.VerticalOffset);

			}
		}
}
