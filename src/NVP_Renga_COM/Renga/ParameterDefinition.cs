using NVP.API.Nodes;

namespace Renga.ParameterDefinition 
{
		[NodeInput("dynamic", typeof(object))]
		public class ParameterDefinition_Constructor : INode 
		{
		public Renga.IParameterDefinition _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IParameterDefinition;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class ParameterDefinition_ConstructorCast : INode 
		{
		public Renga.IParameterDefinition _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IParameterDefinition;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ParameterDefinition", typeof(object))]
		public class ParameterType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ParameterType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("ParameterDefinition", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}
}
