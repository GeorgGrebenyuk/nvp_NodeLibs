using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of Ole object
///</summary>
namespace NVP_nanoCAD_COM._OdaX.AcadOle 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
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

	[NVP_Manifest(
		ViewType = "Modifier")]
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


	[NVP_Manifest(
		Text = "upper left corner) of the OLE object", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///upper left corner) of the OLE object
	///</summary>
	public class InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.InsertionPoint);

		}
	}


	[NVP_Manifest(
		Text = "upper left corner) of the OLE object", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("insPoint", typeof(System.Object))]

	///<summary>
	///upper left corner) of the OLE object
	///</summary>
	public class Set_InsertionPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.InsertionPoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the rotation angle of the OLE object", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the rotation angle of the OLE object
	///</summary>
	public class Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Rotation);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the rotation angle of the OLE object", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("rot", typeof(System.Object))]

	///<summary>
	///Specifies the rotation angle of the OLE object
	///</summary>
	public class Set_Rotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Rotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the OLE object box", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the width of the OLE object box
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the OLE object box", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the OLE object box
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the OLE object box", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the height of the OLE object box
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the OLE object box", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies the height of the OLE object box
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the object as a percentage of original width", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the width of the object as a percentage of original width
	///</summary>
	public class ScaleWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleWidth);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the width of the object as a percentage of original width", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("swidth", typeof(System.Double))]

	///<summary>
	///Specifies the width of the object as a percentage of original width
	///</summary>
	public class Set_ScaleWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the object as a percentage of original height", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies the height of the object as a percentage of original height
	///</summary>
	public class ScaleHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleHeight);

		}
	}


	[NVP_Manifest(
		Text = "Specifies the height of the object as a percentage of original height", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("sheight", typeof(System.Double))]

	///<summary>
	///Specifies the height of the object as a percentage of original height
	///</summary>
	public class Set_ScaleHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Ensures the width and height of the object stay in proportion", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Ensures the width and height of the object stay in proportion
	///</summary>
	public class LockAspectRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LockAspectRatio);

		}
	}


	[NVP_Manifest(
		Text = "Ensures the width and height of the object stay in proportion", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("aspect", typeof(System.Object))]

	///<summary>
	///Ensures the width and height of the object stay in proportion
	///</summary>
	public class Set_LockAspectRatio : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LockAspectRatio = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Specifies whether the OLE object is linked to the original pasted file when opening object for editing", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Specifies whether the OLE object is linked to the original pasted file when opening object for editing
	///</summary>
	public class OleItemType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OleItemType);

		}
	}


	[NVP_Manifest(
		Text = "Specifies whether the OLE object is linked to the original pasted file when opening object for editing", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("OdaX.AcOleType", typeof(System.Object))]

	///<summary>
	///Specifies whether the OLE object is linked to the original pasted file when opening object for editing
	///</summary>
	public class Set_OleItemType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OleItemType = ((OdaX.AcOleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Controls plot quality of OLE object based on file type selected from list", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Controls plot quality of OLE object based on file type selected from list
	///</summary>
	public class OlePlotQuality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OlePlotQuality);

		}
	}


	[NVP_Manifest(
		Text = "Controls plot quality of OLE object based on file type selected from list", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("OdaX.AcOlePlotQuality", typeof(System.Object))]

	///<summary>
	///Controls plot quality of OLE object based on file type selected from list
	///</summary>
	public class Set_OlePlotQuality : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OlePlotQuality = ((OdaX.AcOlePlotQuality)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Text = "Application for editing OLE object", 
		ViewType = "Data")]
	[NodeInput("AcadOle", typeof(object))]

	///<summary>
	///Application for editing OLE object
	///</summary>
	public class OleSourceApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OleSourceApp);

		}
	}


	[NVP_Manifest(
		Text = "Application for editing OLE object", 
		ViewType = "Modifier")]
	[NodeInput("AcadOle", typeof(object))]
	[NodeInput("srcApp", typeof(System.String))]

	///<summary>
	///Application for editing OLE object
	///</summary>
	public class Set_OleSourceApp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OleSourceApp = inputs[1].Value;
			return null;
		}
	}
}
