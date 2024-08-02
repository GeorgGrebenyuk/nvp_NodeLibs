using NVP.API.Nodes;

namespace Renga.BeamStyle 
{
		[NodeInput("dynamic", typeof(object))]
		public class BeamStyle_Constructor : INode 
		{
		public Renga.IBeamStyle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IBeamStyle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class BeamStyle_ConstructorCast : INode 
		{
		public Renga.IBeamStyle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IBeamStyle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BeamStyle", typeof(object))]
		public class Id : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Id);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("BeamStyle", typeof(object))]
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
		[NodeInput("BeamStyle", typeof(object))]
		public class Profile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Profile);

			}
		}
}
