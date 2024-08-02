using NVP.API.Nodes;

namespace OdaX.OdaBlock 
{
		[NodeInput("dynamic", typeof(object))]
		public class OdaBlock_Constructor : INode 
		{
		public OdaX.IOdaBlock _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IOdaBlock;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class OdaBlock_ConstructorCast : INode 
		{
		public OdaX.IOdaBlock _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IOdaBlock;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns all references for a block.
		///</summary>
		[NodeInput("OdaBlock", typeof(object))]
		public class GetReferences : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetReferences);

			}
		}


		///<summary>
		///Returns whether the block is an overlay.
		///</summary>
		[NodeInput("OdaBlock", typeof(object))]
		public class isFromOverlayReference : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.isFromOverlayReference);

			}
		}


		///<summary>
		///Returns whether the block is an external reference with a resolved path.
		///</summary>
		[NodeInput("OdaBlock", typeof(object))]
		public class isResolved : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.isResolved);

			}
		}


		///<summary>
		///Returns whether the block is dependent on an external reference.
		///</summary>
		[NodeInput("OdaBlock", typeof(object))]
		public class isDependent : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.isDependent);

			}
		}


		///<summary>
		///Returns whether the block is an external reference that is unloaded.
		///</summary>
		[NodeInput("OdaBlock", typeof(object))]
		public class isUnloaded : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.isUnloaded);

			}
		}


		///<summary>
		///Specfies whether a block is an overlay.
		///</summary>
		[NodeInput("OdaBlock", typeof(object))]
		[NodeInput("bOverlaid", typeof(System.Object))]
		public class setOverlaid : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.setOverlaid(inputs[1]);
				return null;
			}
		}
}
