using NVP.API.Nodes;

namespace OdaX.AcadLayout 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadLayout_Constructor : INode 
		{
		public OdaX.IAcadLayout _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadLayout;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadLayout_ConstructorCast : INode 
		{
		public OdaX.IAcadLayout _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadLayout;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the block of a layout.
		///</summary>
		[NodeInput("AcadLayout", typeof(object))]
		public class Block : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Block);

			}
		}


		///<summary>
		///Specifies or returns the order of the specified layout.
		///</summary>
		[NodeInput("AcadLayout", typeof(object))]
		public class TabOrder : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TabOrder);

			}
		}


		///<summary>
		///Specifies or returns the order of the specified layout.
		///</summary>
		[NodeInput("AcadLayout", typeof(object))]
		[NodeInput("pOrder", typeof(System.Object))]
		public class Set_TabOrder : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TabOrder = inputs[1];
				return null;
			}
		}
}
