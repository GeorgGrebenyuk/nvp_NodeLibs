using NVP.API.Nodes;

namespace OdaX.OdaOle 
{
		[NodeInput("dynamic", typeof(object))]
		public class OdaOle_Constructor : INode 
		{
		public OdaX.IOdaOle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IOdaOle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class OdaOle_ConstructorCast : INode 
		{
		public OdaX.IOdaOle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IOdaOle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Filename and item to which this OLE object is linked
		///</summary>
		[NodeInput("OdaOle", typeof(object))]
		public class LinkName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LinkName);

			}
		}


		///<summary>
		///Filename to which this OLE object is linked
		///</summary>
		[NodeInput("OdaOle", typeof(object))]
		public class LinkPath : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LinkPath);

			}
		}
}
