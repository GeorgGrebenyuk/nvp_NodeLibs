using NVP.API.Nodes;

namespace Renga.PlumbingFixtureStyleManager 
{
		[NodeInput("dynamic", typeof(object))]
		public class PlumbingFixtureStyleManager_Constructor : INode 
		{
		public Renga.IPlumbingFixtureStyleManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IPlumbingFixtureStyleManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class PlumbingFixtureStyleManager_ConstructorCast : INode 
		{
		public Renga.IPlumbingFixtureStyleManager _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IPlumbingFixtureStyleManager;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PlumbingFixtureStyleManager", typeof(object))]
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
		[NodeInput("PlumbingFixtureStyleManager", typeof(object))]
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
		[NodeInput("PlumbingFixtureStyleManager", typeof(object))]
		[NodeInput("Id", typeof(System.Int32))]
		public class GetPlumbingFixtureStyle : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetPlumbingFixtureStyle(inputs[1]));

			}
		}
}
