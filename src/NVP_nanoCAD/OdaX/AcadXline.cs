using NVP.API.Nodes;

namespace OdaX.AcadXline 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadXline_Constructor : INode 
		{
		public OdaX.IAcadXline _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadXline;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadXline_ConstructorCast : INode 
		{
		public OdaX.IAcadXline _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadXline;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
		///</summary>
		[NodeInput("AcadXline", typeof(object))]
		public class BasePoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.BasePoint);

			}
		}


		///<summary>
		///Specify the X, Y, Z coordinate for the base point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
		///</summary>
		[NodeInput("AcadXline", typeof(object))]
		[NodeInput("BasePoint", typeof(System.Object))]
		public class Set_BasePoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.BasePoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
		///</summary>
		[NodeInput("AcadXline", typeof(object))]
		public class SecondPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SecondPoint);

			}
		}


		///<summary>
		///Specify the X, Y, Z coordinate for the second point of the Xline or use the Pick Point button to set X, Y, Z values simultaneously
		///</summary>
		[NodeInput("AcadXline", typeof(object))]
		[NodeInput("SecondPoint", typeof(System.Object))]
		public class Set_SecondPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SecondPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specify the X, Y, Z coordinate for the direction vector of the Xline
		///</summary>
		[NodeInput("AcadXline", typeof(object))]
		public class DirectionVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DirectionVector);

			}
		}


		///<summary>
		///Specify the X, Y, Z coordinate for the direction vector of the Xline
		///</summary>
		[NodeInput("AcadXline", typeof(object))]
		[NodeInput("dirVector", typeof(System.Object))]
		public class Set_DirectionVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.DirectionVector = inputs[1];
				return null;
			}
		}


		///<summary>
		///Creates a new entity object by offsetting the Xline by a specified distance
		///</summary>
		[NodeInput("AcadXline", typeof(object))]
		[NodeInput("Distance", typeof(System.Double))]
		public class Offset : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Offset(inputs[1]));

			}
		}
}
