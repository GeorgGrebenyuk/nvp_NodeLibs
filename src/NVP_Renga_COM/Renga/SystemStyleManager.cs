using NVP.API.Nodes;

namespace Renga.SystemStyleManager 
{
		[NodeInput("dynamic", typeof(object))]
		public class SystemStyleManager_Constructor : INode 
		{
		public Renga.ISystemStyleManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.ISystemStyleManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class SystemStyleManager_ConstructorCast : INode 
		{
		public Renga.ISystemStyleManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.ISystemStyleManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("SystemStyleManager", typeof(object))]
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
		[NodeInput("SystemStyleManager", typeof(object))]
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
		[NodeInput("SystemStyleManager", typeof(object))]
		[NodeInput("Id", typeof(System.Int32))]
		public class GetSystemStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetSystemStyle(inputs[1]));

			}
		}
}
