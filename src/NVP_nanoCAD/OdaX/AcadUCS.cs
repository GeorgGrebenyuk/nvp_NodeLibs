using NVP.API.Nodes;

namespace OdaX.AcadUCS 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadUCS_Constructor : INode 
		{
		public OdaX.IAcadUCS _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadUCS;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadUCS_ConstructorCast : INode 
		{
		public OdaX.IAcadUCS _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadUCS;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies the name of the object
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
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
		///Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		public class Origin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Origin);

			}
		}


		///<summary>
		///Specifies the origin of the UCS, block, layout, or raster image in WCS coordinates
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		[NodeInput("Origin", typeof(System.Object))]
		public class Set_Origin : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Origin = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the X direction of the given UCS
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		public class XVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.XVector);

			}
		}


		///<summary>
		///Specifies the X direction of the given UCS
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		[NodeInput("XVector", typeof(System.Object))]
		public class Set_XVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.XVector = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the Y direction of the given UCS
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		public class YVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.YVector);

			}
		}


		///<summary>
		///Specifies the Y direction of the given UCS
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		[NodeInput("YVector", typeof(System.Object))]
		public class Set_YVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.YVector = inputs[1];
				return null;
			}
		}


		///<summary>
		///Gets the transformation matrix consisting of UCS coordinate system data
		///</summary>
		[NodeInput("AcadUCS", typeof(object))]
		public class GetUCSMatrix : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GetUCSMatrix);

			}
		}
}
