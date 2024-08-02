using NVP.API.Nodes;

namespace OdaX.AcadDimStyle 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadDimStyle_Constructor : INode 
		{
		public OdaX.IAcadDimStyle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadDimStyle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadDimStyle_ConstructorCast : INode 
		{
		public OdaX.IAcadDimStyle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadDimStyle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the name of a dimension style.
		///</summary>
		[NodeInput("AcadDimStyle", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of a dimension style.
		///</summary>
		[NodeInput("AcadDimStyle", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Copies dimension style data to an existing dimension style.
		///</summary>
		[NodeInput("AcadDimStyle", typeof(object))]
		[NodeInput("StyleSource", typeof(System.Object))]
		public class CopyFrom : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.CopyFrom(inputs[1]);
				return null;
			}
		}
}
