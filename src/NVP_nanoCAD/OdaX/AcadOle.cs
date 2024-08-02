using NVP.API.Nodes;

namespace OdaX.AcadOle 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadOle_Constructor : INode 
		{
		public OdaX.IAcadOle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadOle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadOle_ConstructorCast : INode 
		{
		public OdaX.IAcadOle _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadOle;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///upper left corner) of the OLE object
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class InsertionPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.InsertionPoint);

			}
		}


		///<summary>
		///upper left corner) of the OLE object
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("insPoint", typeof(System.Object))]
		public class Set_InsertionPoint : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.InsertionPoint = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the rotation angle of the OLE object
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Rotation);

			}
		}


		///<summary>
		///Specifies the rotation angle of the OLE object
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("rot", typeof(System.Object))]
		public class Set_Rotation : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Rotation = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the width of the OLE object box
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Width);

			}
		}


		///<summary>
		///Specifies the width of the OLE object box
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("Width", typeof(System.Double))]
		public class Set_Width : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Width = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the height of the OLE object box
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Height);

			}
		}


		///<summary>
		///Specifies the height of the OLE object box
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("Height", typeof(System.Double))]
		public class Set_Height : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Height = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the width of the object as a percentage of original width
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class ScaleWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleWidth);

			}
		}


		///<summary>
		///Specifies the width of the object as a percentage of original width
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("swidth", typeof(System.Double))]
		public class Set_ScaleWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ScaleWidth = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies the height of the object as a percentage of original height
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class ScaleHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ScaleHeight);

			}
		}


		///<summary>
		///Specifies the height of the object as a percentage of original height
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("sheight", typeof(System.Double))]
		public class Set_ScaleHeight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ScaleHeight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Ensures the width and height of the object stay in proportion
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class LockAspectRatio : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LockAspectRatio);

			}
		}


		///<summary>
		///Ensures the width and height of the object stay in proportion
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("aspect", typeof(System.Object))]
		public class Set_LockAspectRatio : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LockAspectRatio = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies whether the OLE object is linked to the original pasted file when opening object for editing
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class OleItemType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OleItemType);

			}
		}


		///<summary>
		///Specifies whether the OLE object is linked to the original pasted file when opening object for editing
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("pType", typeof(System.Object))]
		public class Set_OleItemType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.OleItemType = inputs[1];
				return null;
			}
		}


		///<summary>
		///Controls plot quality of OLE object based on file type selected from list
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class OlePlotQuality : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OlePlotQuality);

			}
		}


		///<summary>
		///Controls plot quality of OLE object based on file type selected from list
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("pPQuality", typeof(System.Object))]
		public class Set_OlePlotQuality : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.OlePlotQuality = inputs[1];
				return null;
			}
		}


		///<summary>
		///Application for editing OLE object
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		public class OleSourceApp : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.OleSourceApp);

			}
		}


		///<summary>
		///Application for editing OLE object
		///</summary>
		[NodeInput("AcadOle", typeof(object))]
		[NodeInput("srcApp", typeof(System.String))]
		public class Set_OleSourceApp : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.OleSourceApp = inputs[1];
				return null;
			}
		}
}
