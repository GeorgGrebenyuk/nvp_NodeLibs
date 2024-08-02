using NVP.API.Nodes;

namespace Renga.PortDuctParams 
{
		[NodeInput("dynamic", typeof(object))]
		public class PortDuctParams_Constructor : INode 
		{
		public Renga.IPortDuctParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as Renga.IPortDuctParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class PortDuctParams_ConstructorCast : INode 
		{
		public Renga.IPortDuctParams _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as Renga.IPortDuctParams;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PortDuctParams", typeof(object))]
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
		[NodeInput("PortDuctParams", typeof(object))]
		public class DuctFormType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DuctFormType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PortDuctParams", typeof(object))]
		public class NominalDiameter : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NominalDiameter);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PortDuctParams", typeof(object))]
		public class NominalWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NominalWidth);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("PortDuctParams", typeof(object))]
		public class NominalHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NominalHeight);

			}
		}
}
