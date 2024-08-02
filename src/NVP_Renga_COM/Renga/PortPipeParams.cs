using NVP.API.Nodes;

namespace Renga.PortPipeParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class PortPipeParams_Constructor : INode 
		{
		public Renga.IPortPipeParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IPortPipeParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class PortPipeParams_ConstructorCast : INode 
		{
		public Renga.IPortPipeParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IPortPipeParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PortPipeParams", typeof(object))]
		public class ConnectionType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ConnectionType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PortPipeParams", typeof(object))]
		public class NominalDiameter : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NominalDiameter);

			}
		}
}
