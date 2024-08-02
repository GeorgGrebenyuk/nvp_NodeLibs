using NVP.API.Nodes;

namespace OdaX.AcadMLine 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadMLine_Constructor : INode 
		{
		public OdaX.IAcadMLine _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadMLine;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadMLine_ConstructorCast : INode 
		{
		public OdaX.IAcadMLine _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadMLine;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the style name of a multiline.
		///</summary>
		[NodeInput("AcadMLine", typeof(object))]
		public class StyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StyleName);

			}
		}


		///<summary>
		///Specifies or returns the vertices of a multline.
		///</summary>
		[NodeInput("AcadMLine", typeof(object))]
		public class Coordinates : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Coordinates);

			}
		}


		///<summary>
		///Specifies or returns the vertices of a multline.
		///</summary>
		[NodeInput("AcadMLine", typeof(object))]
		[NodeInput("Vertices", typeof(System.Object))]
		public class Set_Coordinates : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Coordinates = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the orientation of a multiline.
		///</summary>
		[NodeInput("AcadMLine", typeof(object))]
		public class Justification : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Justification);

			}
		}


		///<summary>
		///Specifies or returns the orientation of a multiline.
		///</summary>
		[NodeInput("AcadMLine", typeof(object))]
		[NodeInput("Justification", typeof(System.Object))]
		public class Set_Justification : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Justification = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the scale of a multiline.
		///</summary>
		[NodeInput("AcadMLine", typeof(object))]
		public class MLineScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MLineScale);

			}
		}


		///<summary>
		///Specifies or returns the scale of a multiline.
		///</summary>
		[NodeInput("AcadMLine", typeof(object))]
		[NodeInput("scale", typeof(System.Double))]
		public class Set_MLineScale : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MLineScale = inputs[1];
				return null;
			}
		}
}
